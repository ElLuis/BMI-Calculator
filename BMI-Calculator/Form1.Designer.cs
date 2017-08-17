namespace BMI_Calculator
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imperialUnitsButton = new System.Windows.Forms.RadioButton();
            this.myHeightLabel = new System.Windows.Forms.Label();
            this.myHeightTextBox = new System.Windows.Forms.TextBox();
            this.myWeightLable = new System.Windows.Forms.Label();
            this.metricUnitsButton = new System.Windows.Forms.RadioButton();
            this.myWeightTextBox = new System.Windows.Forms.TextBox();
            this.calculateBMIButton = new System.Windows.Forms.Button();
            this.bmiScaleTextBox = new System.Windows.Forms.TextBox();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.bmiScaleLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.1529F));
            this.tableLayoutPanel1.Controls.Add(this.imperialUnitsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.myHeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.myHeightTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.myWeightLable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metricUnitsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.myWeightTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.calculateBMIButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BMITextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bmiScaleLable, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bmiScaleTextBox, 1, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.92593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.07407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // imperialUnitsButton
            // 
            this.imperialUnitsButton.AutoSize = true;
            this.imperialUnitsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.imperialUnitsButton.Location = new System.Drawing.Point(3, 3);
            this.imperialUnitsButton.Name = "imperialUnitsButton";
            this.imperialUnitsButton.Size = new System.Drawing.Size(142, 36);
            this.imperialUnitsButton.TabIndex = 0;
            this.imperialUnitsButton.TabStop = true;
            this.imperialUnitsButton.Text = "Imperial";
            this.imperialUnitsButton.UseVisualStyleBackColor = true;
            this.imperialUnitsButton.CheckedChanged += new System.EventHandler(this.imperialUnitsButton_CheckedChanged);
            // 
            // myHeightLabel
            // 
            this.myHeightLabel.AutoSize = true;
            this.myHeightLabel.Location = new System.Drawing.Point(3, 54);
            this.myHeightLabel.Name = "myHeightLabel";
            this.myHeightLabel.Size = new System.Drawing.Size(151, 32);
            this.myHeightLabel.TabIndex = 2;
            this.myHeightLabel.Text = "My Height";
            // 
            // myHeightTextBox
            // 
            this.myHeightTextBox.Location = new System.Drawing.Point(3, 109);
            this.myHeightTextBox.Name = "myHeightTextBox";
            this.myHeightTextBox.Size = new System.Drawing.Size(100, 39);
            this.myHeightTextBox.TabIndex = 3;
            this.myHeightTextBox.TextChanged += new System.EventHandler(this.myHeightTextBox_TextChanged);
            // 
            // myWeightLable
            // 
            this.myWeightLable.AutoSize = true;
            this.myWeightLable.Location = new System.Drawing.Point(166, 54);
            this.myWeightLable.Name = "myWeightLable";
            this.myWeightLable.Size = new System.Drawing.Size(155, 32);
            this.myWeightLable.TabIndex = 4;
            this.myWeightLable.Text = "My Weight";
            // 
            // metricUnitsButton
            // 
            this.metricUnitsButton.AutoSize = true;
            this.metricUnitsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metricUnitsButton.Location = new System.Drawing.Point(166, 3);
            this.metricUnitsButton.Name = "metricUnitsButton";
            this.metricUnitsButton.Size = new System.Drawing.Size(116, 36);
            this.metricUnitsButton.TabIndex = 1;
            this.metricUnitsButton.TabStop = true;
            this.metricUnitsButton.Text = "Metric";
            this.metricUnitsButton.UseVisualStyleBackColor = true;
            this.metricUnitsButton.CheckedChanged += new System.EventHandler(this.metricUnitsButton_CheckedChanged);
            // 
            // myWeightTextBox
            // 
            this.myWeightTextBox.Location = new System.Drawing.Point(166, 109);
            this.myWeightTextBox.Name = "myWeightTextBox";
            this.myWeightTextBox.Size = new System.Drawing.Size(103, 39);
            this.myWeightTextBox.TabIndex = 1;
            this.myWeightTextBox.TextChanged += new System.EventHandler(this.myWeightTextBox_TextChanged);
            // 
            // calculateBMIButton
            // 
            this.calculateBMIButton.BackColor = System.Drawing.Color.Maroon;
            this.calculateBMIButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.calculateBMIButton.Location = new System.Drawing.Point(3, 182);
            this.calculateBMIButton.Name = "calculateBMIButton";
            this.calculateBMIButton.Size = new System.Drawing.Size(157, 75);
            this.calculateBMIButton.TabIndex = 1;
            this.calculateBMIButton.Text = "Calculate \r\nBMI";
            this.calculateBMIButton.UseVisualStyleBackColor = false;
            this.calculateBMIButton.Click += new System.EventHandler(this.calculateBMIButton_Click);
            // 
            // bmiScaleTextBox
            // 
            this.bmiScaleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bmiScaleTextBox.Enabled = false;
            this.bmiScaleTextBox.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiScaleTextBox.ForeColor = System.Drawing.Color.White;
            this.bmiScaleTextBox.Location = new System.Drawing.Point(166, 267);
            this.bmiScaleTextBox.Multiline = true;
            this.bmiScaleTextBox.Name = "bmiScaleTextBox";
            this.bmiScaleTextBox.Size = new System.Drawing.Size(158, 29);
            this.bmiScaleTextBox.TabIndex = 6;
            this.bmiScaleTextBox.TextChanged += new System.EventHandler(this.bmiScaleTextBox_TextChanged);
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BMITextBox.Enabled = false;
            this.BMITextBox.ForeColor = System.Drawing.Color.White;
            this.BMITextBox.Location = new System.Drawing.Point(166, 182);
            this.BMITextBox.Multiline = true;
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(158, 37);
            this.BMITextBox.TabIndex = 5;
            this.BMITextBox.TextChanged += new System.EventHandler(this.BMITextBox_TextChanged);
            // 
            // bmiScaleLable
            // 
            this.bmiScaleLable.AutoSize = true;
            this.bmiScaleLable.BackColor = System.Drawing.Color.Transparent;
            this.bmiScaleLable.ForeColor = System.Drawing.Color.Maroon;
            this.bmiScaleLable.Location = new System.Drawing.Point(3, 264);
            this.bmiScaleLable.Name = "bmiScaleLable";
            this.bmiScaleLable.Size = new System.Drawing.Size(103, 32);
            this.bmiScaleLable.TabIndex = 7;
            this.bmiScaleLable.Text = " Scale:";
            this.bmiScaleLable.Click += new System.EventHandler(this.bmiScaleLable_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(328, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton metricUnitsButton;
        private System.Windows.Forms.RadioButton imperialUnitsButton;
        private System.Windows.Forms.Label myHeightLabel;
        private System.Windows.Forms.TextBox myHeightTextBox;
        private System.Windows.Forms.Label myWeightLable;
        private System.Windows.Forms.TextBox myWeightTextBox;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button calculateBMIButton;
        private System.Windows.Forms.TextBox bmiScaleTextBox;
        private System.Windows.Forms.Label bmiScaleLable;
    }
}

