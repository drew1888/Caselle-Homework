using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleCalculator
{
    public partial class TriangleForm : Form
    {

        private decimal _aValue;
        private decimal _bValue;
        private decimal _cValue;

        private string _sideTriangleType;
        private string _angleTriangleType;

        private RichTextBox _rtbOutput;

        public TriangleForm()
        {
            InitializeComponent();

            _rtbOutput = rtbOutput;
        }

        private void nudAInput_ValueChanged(object sender, EventArgs e)
        {
            _aValue = nudAInput.Value;
            CalculateTriangle();
        }

        private void nudBInput_ValueChanged(object sender, EventArgs e)
        {
            _bValue = nudBInput.Value;
            CalculateTriangle();
        }

        private void nudCInput_ValueChanged(object sender, EventArgs e)
        {
            _cValue = nudCInput.Value;
            CalculateTriangle();
        }

        private void CalculateTriangle()
        {
            if (ThreeInputsGreaterThanZero())
            {
                if (CheckForValidTriangle())
                { 
                    CalculateTriangleSideType();
                    CalculateTriangleAngleType();
                    WriteToOutput("These side lengths produce a valid " + _sideTriangleType.ToString() + " " + _angleTriangleType.ToString() + " triangle");
                }
                else
                {
                    WriteToOutput("These side lengths don't produce a valid triangle");
                }
            }
            else
            {
                WriteToOutput("All values must be greater than zero");
            }
        }

        private bool ThreeInputsGreaterThanZero()
        {
            if (_aValue > 0 && _bValue > 0 && _cValue > 0)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        private bool CheckForValidTriangle()
        {
            decimal[] tempArray = new decimal[] { _aValue, _bValue, _cValue };
            decimal smallestNumber = tempArray.Min(x => x);
            decimal secondSmalletNumber = tempArray.OrderBy(x => x).Skip(1).First();
            decimal largestNumber = tempArray.Max(x => x);
            decimal sumOfSmallest = smallestNumber + secondSmalletNumber;

            if (sumOfSmallest > largestNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CalculateTriangleSideType()
        {
            decimal[] tempArray = new decimal[] { _aValue, _bValue, _cValue };

            // check for Scalene
            if (tempArray.GroupBy(x => x).All(y => y.Count() == 1))
            {
                _sideTriangleType = "Scalene";
            }
            // check for Equilateral
            else if (tempArray.GroupBy(x => x).Any(y => y.Count() > 2))
            {
                _sideTriangleType = "Equilateral";
            }
            // is Isosceles 
            else
            {
                _sideTriangleType = "Isosceles";
            }
        }

        private void CalculateTriangleAngleType()
        {
            double aValue = Convert.ToDouble(_aValue);
            double bValue = Convert.ToDouble(_bValue);
            double cValue = Convert.ToDouble(_cValue);

            // cosine rule a² = b² + c² - 2bccosA
            // A = cos^-1((b² + c² - a²)/(2bc)
            double angleA = Math.Acos((Math.Pow(bValue, 2) + Math.Pow(cValue, 2) - Math.Pow(aValue, 2)) / (2 * bValue * cValue)) * (180/Math.PI);
            double angleB = Math.Acos((Math.Pow(aValue, 2) + Math.Pow(cValue, 2) - Math.Pow(bValue, 2)) / (2 * aValue * cValue)) * (180 / Math.PI);
            double angleC = Math.Acos((Math.Pow(aValue, 2) + Math.Pow(bValue, 2) - Math.Pow(cValue, 2)) / (2 * aValue * bValue)) * (180 / Math.PI);

            double[] tempArray = new double[] { angleA, angleB, angleC };
            // check for Equiangular 
            if (tempArray.GroupBy(x => x).Any(y => y.Count() > 2))
            {
                _angleTriangleType = "Equiangular";
            }
            // check for Right 
            else if (tempArray.Any(x => x == 90))
            {
                _angleTriangleType = "Right";
            }
            // check for Obtuse 
            else if (tempArray.Any(x => x > 90))
            {
                _angleTriangleType = "Obtuse";
            }
            // is Acute  
            else
            {
                _angleTriangleType = "Acute";
            }
        }

        private void WriteToOutput(string outputString)
        {
            _rtbOutput.Clear();
            _rtbOutput.AppendText(outputString);
        }
    }
}
