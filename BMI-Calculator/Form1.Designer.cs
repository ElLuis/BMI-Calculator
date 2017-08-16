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
            this.metricUnitsButton = new System.Windows.Forms.RadioButton();
            this.myHeightLabel = new System.Windows.Forms.Label();
            this.myHeightTextBox = new System.Windows.Forms.TextBox();
            this.myWeightLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metricUnitsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imperialUnitsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.myHeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.myHeightTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.myWeightLable, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.10204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.89796F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imperialUnitsButton
            // 
            this.imperialUnitsButton.AutoSize = true;
            this.imperialUnitsButton.Location = new System.Drawing.Point(3, 3);
            this.imperialUnitsButton.Name = "imperialUnitsButton";
            this.imperialUnitsButton.Size = new System.Drawing.Size(61, 17);
            this.imperialUnitsButton.TabIndex = 0;
            this.imperialUnitsButton.TabStop = true;
            this.imperialUnitsButton.Text = "Imperial";
            this.imperialUnitsButton.UseVisualStyleBackColor = true;
            // 
            // metricUnitsButton
            // 
            this.metricUnitsButton.AutoSize = true;
            this.metricUnitsButton.Location = new System.Drawing.Point(143, 3);
            this.metricUnitsButton.Name = "metricUnitsButton";
            this.metricUnitsButton.Size = new System.Drawing.Size(54, 17);
            this.metricUnitsButton.TabIndex = 1;
            this.metricUnitsButton.TabStop = true;
            this.metricUnitsButton.Text = "Metric";
            this.metricUnitsButton.UseVisualStyleBackColor = true;
            // 
            // myHeightLabel
            // 
            this.myHeightLabel.AutoSize = true;
            this.myHeightLabel.Location = new System.Drawing.Point(3, 29);
            this.myHeightLabel.Name = "myHeightLabel";
            this.myHeightLabel.Size = new System.Drawing.Size(55, 13);
            this.myHeightLabel.TabIndex = 2;
            this.myHeightLabel.Text = "My Height";
            // 
            // myHeightTextBox
            // 
            this.myHeightTextBox.Location = new System.Drawing.Point(3, 56);
            this.myHeightTextBox.Name = "myHeightTextBox";
            this.myHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.myHeightTextBox.TabIndex = 3;
            // 
            // myWeightLable
            // 
            this.myWeightLable.AutoSize = true;
            this.myWeightLable.Location = new System.Drawing.Point(143, 29);
            this.myWeightLable.Name = "myWeightLable";
            this.myWeightLable.Size = new System.Drawing.Size(58, 13);
            this.myWeightLable.TabIndex = 4;
            this.myWeightLable.Text = "My Weight";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
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
    }
}

