namespace TriangleCalculator
{
    partial class TriangleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblSideC = new System.Windows.Forms.Label();
            this.nudAInput = new System.Windows.Forms.NumericUpDown();
            this.nudBInput = new System.Windows.Forms.NumericUpDown();
            this.nudCInput = new System.Windows.Forms.NumericUpDown();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(53, 60);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(69, 13);
            this.lblSideA.TabIndex = 0;
            this.lblSideA.Text = "Side a length";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(53, 107);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(69, 13);
            this.lblSideB.TabIndex = 1;
            this.lblSideB.Text = "Side b length";
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Location = new System.Drawing.Point(53, 160);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(69, 13);
            this.lblSideC.TabIndex = 2;
            this.lblSideC.Text = "Side c length";
            // 
            // nudAInput
            // 
            this.nudAInput.Location = new System.Drawing.Point(155, 53);
            this.nudAInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAInput.Name = "nudAInput";
            this.nudAInput.Size = new System.Drawing.Size(120, 20);
            this.nudAInput.TabIndex = 3;
            this.nudAInput.ValueChanged += new System.EventHandler(this.nudAInput_ValueChanged);
            // 
            // nudBInput
            // 
            this.nudBInput.Location = new System.Drawing.Point(155, 100);
            this.nudBInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBInput.Name = "nudBInput";
            this.nudBInput.Size = new System.Drawing.Size(120, 20);
            this.nudBInput.TabIndex = 4;
            this.nudBInput.ValueChanged += new System.EventHandler(this.nudBInput_ValueChanged);
            // 
            // nudCInput
            // 
            this.nudCInput.Location = new System.Drawing.Point(155, 153);
            this.nudCInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCInput.Name = "nudCInput";
            this.nudCInput.Size = new System.Drawing.Size(120, 20);
            this.nudCInput.TabIndex = 5;
            this.nudCInput.ValueChanged += new System.EventHandler(this.nudCInput_ValueChanged);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 223);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(408, 54);
            this.rtbOutput.TabIndex = 6;
            this.rtbOutput.Text = "";
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 329);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.nudCInput);
            this.Controls.Add(this.nudBInput);
            this.Controls.Add(this.nudAInput);
            this.Controls.Add(this.lblSideC);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.Name = "TriangleForm";
            this.Text = "Triangle Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudAInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.NumericUpDown nudAInput;
        private System.Windows.Forms.NumericUpDown nudBInput;
        private System.Windows.Forms.NumericUpDown nudCInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

