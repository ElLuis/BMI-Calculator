using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    //Luis Sanchez - 300796405  
    //COMP125
    //BMI Calculator
    //Assignment 5
    //8/16/2017
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
