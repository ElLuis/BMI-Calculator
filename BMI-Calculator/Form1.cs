using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    //Imperial formula: weightLbs * 703 / heightIn * heightIn
    //Metric formula: weightKgs / heightM * heightM
    public partial class BMICalculator : Form
    {
        private double _heightIn, _heightM, _weightLb, _weightKg, _imperialBMI, _metricBMI;
        private const double _underweight = 18.5; // BMI <= 18.5
        private const double _normal = 24.9; //BMI > 18.5 && BMI <= 24.9
        private const double _overweight = 29.9;// BMI >= 25 && BMI <= 29.9
        private const double _obese = 30; // BMI >= 30 
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imperialUnitsButton_CheckedChanged(object sender, EventArgs e) //imperial
        {
            if (imperialUnitsButton.Checked)
            {
                myHeightLabel.Text = "Height(In)";
                myWeightLable.Text = "Weight(Kg)";
            }
        }

        private void metricUnitsButton_CheckedChanged(object sender, EventArgs e) //metric
        {
            if (metricUnitsButton.Checked)
            {
                myHeightLabel.Text = "Height(M)";
                myWeightLable.Text = "Weight(Lb)";
            }
        }

        private void bmiScaleLable_Click(object sender, EventArgs e) //ignore
        {

        }

        private void myHeightTextBox_TextChanged(object sender, EventArgs e) //height
        {

        }

        private void myWeightTextBox_TextChanged(object sender, EventArgs e) //weight
        {

        }

        private void calculateBMIButton_Click(object sender, EventArgs e) //calculate
        {

        }

        private void BMITextBox_TextChanged(object sender, EventArgs e) //BMI result
        {

        }

        private void bmiScaleTextBox_TextChanged(object sender, EventArgs e) //scale
        {

        }
    }
}
