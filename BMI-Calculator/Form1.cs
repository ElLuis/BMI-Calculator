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
    //Luis Sanchez - 300796405  
    //COMP125
    //BMI Calculator
    //Assignment 5
    //8/16/2017

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
         
                myHeightLabel.Text = "Height(In)";
                myWeightLable.Text = "Weight(Lb)";

                
        }

        private void metricUnitsButton_CheckedChanged(object sender, EventArgs e) //metric
        {
            if (metricUnitsButton.Checked)
            {
                myHeightLabel.Text = "Height(M)";
                myWeightLable.Text = "Weight(Kg)";
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
            //Imperial BMI calculation
            if (imperialUnitsButton.Checked)
            {
                _weightLb = Double.Parse(myWeightTextBox.Text);
                if (Double.Parse(myHeightTextBox.Text) > 8)
                {
                    _heightIn = Double.Parse(myHeightTextBox.Text);
                    _imperialBMI = _weightLb * 703 / (_heightIn * _heightIn);
                }
                else
                {
                    _heightIn = Double.Parse(myHeightTextBox.Text) * 12;
                    _imperialBMI = _weightLb * 703 / (_heightIn * _heightIn);
                }
                BMITextBox.Text = _imperialBMI.ToString("F2");
            }

            //metric BMI calculation 

            if (metricUnitsButton.Checked)
            {
                _weightKg = Double.Parse(myWeightTextBox.Text);
                if (Double.Parse(myHeightTextBox.Text) > 2.5)
                {
                    _heightM = Double.Parse(myHeightTextBox.Text) / 100;
                    _metricBMI = _weightKg / (_heightM * _heightM);
                   
                }
                else
                {
                    _heightM = Double.Parse(myHeightTextBox.Text) ;
                    _metricBMI = _weightKg / (_heightM * _heightM);
                }
                BMITextBox.Text = _metricBMI.ToString("F2");
               

            }
            //Scale options 
            if (_imperialBMI <= 18.5 || _metricBMI <= 18.5)
            { bmiScaleTextBox.Text = "Underweight"; }
            if ((_imperialBMI > 18.5 && _imperialBMI <= 24.9) || _metricBMI > 18.5 && _metricBMI <= 24.9)
            { bmiScaleTextBox.Text = "Normal"; }
            if ((_imperialBMI >= 25 && _imperialBMI <= 29.9) || _metricBMI >= 25 && _metricBMI <= 29.9)
            { bmiScaleTextBox.Text = "Overweight"; }
            if (_imperialBMI >= 30 || _metricBMI >= 30)
            { bmiScaleTextBox.Text = "Obese"; }
            
        }

        //uncheck buttons
        
        private void BMITextBox_TextChanged(object sender, EventArgs e) //BMI result
        {
            myHeightTextBox.Text = "";
            myWeightTextBox.Text = "";
        }

        private void bmiScaleTextBox_TextChanged(object sender, EventArgs e) //scale
        {

            
        }
    }
}
