using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
/*  This program was written by Gail Mosdell
    It forms the base of a converter program for the OS-Assessment Two for Cert IV
    Date : February 2017
*/
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            lbl_Display.Text = "";
            lbl_Display.TextAlign = ContentAlignment.MiddleRight;
        }

        // Global Variables and Constants
        double dbl_UofM;
        double dbl_Convert;
        string FromMeasurementTypeText;
        string ToMeasurementTypeText;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Exits the program
        }

        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
            const double CM_TO_INCH = 0.3937;
            FromMeasurementTypeText = "centimetres";
            ToMeasurementTypeText = "inches";

            DoTheConversion(CM_TO_INCH, FromMeasurementTypeText, ToMeasurementTypeText);
            // calls DoTheConversion
        }



        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double M_TO_FT = 3.28084;
            FromMeasurementTypeText = "metres";
            ToMeasurementTypeText = "feet";

            DoTheConversion(M_TO_FT, FromMeasurementTypeText, ToMeasurementTypeText);
            // calls DoTheConversion
        }




        private void btn_C_to_Fahrenheit_Click(object sender, EventArgs e)
        {
            const double C_TO_FHeit = 1.8;
            FromMeasurementTypeText = "degrees celcius";
            ToMeasurementTypeText = "degrees fahrenheit";

            DoTheConversion(C_TO_FHeit, FromMeasurementTypeText, ToMeasurementTypeText, 32);
            // calls DoTheConversion
        }

        private void btn_CM_to_Feet_Click(object sender, EventArgs e)
        {
            const double CM_TO_Feet = (1 / 30.48);
            FromMeasurementTypeText = "centimetres";
            ToMeasurementTypeText = "feet";

            DoTheConversion(CM_TO_Feet, FromMeasurementTypeText, ToMeasurementTypeText);
            // calls DoTheConversion
        }

        private void btn_KM_to_Miles_Click(object sender, EventArgs e)
        {
            const double KM_TO_Miles = (1 / 1.609344);
            FromMeasurementTypeText = "kilometres";
            ToMeasurementTypeText = "miles";

            DoTheConversion(KM_TO_Miles, FromMeasurementTypeText, ToMeasurementTypeText);
            // calls DoTheConversion
        }

        private void DoTheConversion(double CM_TO_INCH, string FromMeasurementTypeText, string ToMeasurementTypeText)
        {
            DoTheConversion(CM_TO_INCH, FromMeasurementTypeText, ToMeasurementTypeText, 0);
        }


        private void DoTheConversion(double CM_TO_INCH, string FromMeasurementTypeText, string ToMeasurementTypeText, double AddOnValue)
        {
            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * CM_TO_INCH + AddOnValue;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = String.Format("{0} {1} is converted to ", txt_UnitOfMeasure.Text, ConvertToSingular(FromMeasurementTypeText, dbl_UofM));
                lbl_Convert.Text = String.Format(" {0}.", ConvertToSingular(ToMeasurementTypeText, dbl_Convert));
            }
            // converts passed in metric values to imperial
        }


        private string ConvertToSingular ( string inputString, double number)
        {
            string convertedString = inputString;

            if (number == 1)
            {
                if (inputString.Equals("feet"))
                {
                    convertedString = "foot";
                }
                else if (inputString.Equals("inches"))
                {
                    convertedString = "inch";
                }
                else if (inputString.Equals("degrees celcius"))
                {
                    convertedString = "degree celcius";
                }
                else if (inputString.Equals("degrees fahrenheit"))
                {
                    convertedString = "degree fahrenheit";
                }
                else
                {

                    convertedString = inputString.Substring(0, inputString.Length - 1);
                }
            }

            return convertedString;
            // pluralises passed in string to singular
        }




    }
}