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

            // initializing the label to display nothing.
            lbl_Display.Text = "";
            lbl_Display.TextAlign = ContentAlignment.MiddleRight;

          
            // creating new array of strings to hold the different options to convert between.
            string[] converionOptionsArray = new string[] 
            {
                "Centimetres to Inches",
                "Metres to Feet",
                "Celcius to Fahrenheit",
                "Centimetres to Feet",
                "Kilometres to Miles"
            };

            // adding the array of strings holding the different options to convert between to the combo box.
            cbSelectCalculation.Items.AddRange(converionOptionsArray);
        }


        // Global Variables and Constants.
        double ValueToConvert;
        double ConvertedValue;
        const double cmToInchesRatio = 0.3937;
        const double mToInchesRatio = 3.28084;
        const double celciusToFHeitRatio = 1.8;
        const double cmToFeetRatio = (1 / 30.48);
        const double kmToMilesRatio = (1 / 1.609344);
        string FromMeasurementTypeText;
        string ToMeasurementTypeText;
        string message;


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            // Exits the program.
            Application.Exit();
        }

        private void DoTheConversion(double ConversionRatio, string FromMeasurementTypeText, string ToMeasurementTypeText)
        {
            DoTheConversion(ConversionRatio, FromMeasurementTypeText, ToMeasurementTypeText, 0);
        }

        private void DoTheConversion(double ConversionRatio, string FromMeasurementTypeText, string ToMeasurementTypeText, double AddOnValue)
        {
            if (!double.TryParse(txt_UnitOfMeasure.Text, out ValueToConvert))
            {
                // Validation for a numeric value.
                message = "A numeric must be entered. Please re-enter the value.";
                MessageBox.Show(message);
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                // converts passed in metric values to imperial.
                ConvertedValue = ValueToConvert * ConversionRatio + AddOnValue;
                txt_Convert.Text = ConvertedValue.ToString();
                lbl_Display.Text = String.Format("{0} {1} is converted to ", txt_UnitOfMeasure.Text, ConvertToSingular(FromMeasurementTypeText, ValueToConvert));
                lbl_Convert.Text = String.Format(" {0}.", ConvertToSingular(ToMeasurementTypeText, ConvertedValue));
            }
        }

        private string ConvertToSingular ( string inputString, double number)
        {
            // Converts passed in string to singular if required.
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
        }

        private void cbSelectCalculation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // checks what value in combo box is selected and based on the value converts to imperial.
            switch (cbSelectCalculation.SelectedIndex)
            {
                case 0:
                    FromMeasurementTypeText = "centimetres";
                    ToMeasurementTypeText = "inches";
                    DoTheConversion(cmToInchesRatio, FromMeasurementTypeText, ToMeasurementTypeText);
                    break;
                case 1:
                    FromMeasurementTypeText = "metres";
                    ToMeasurementTypeText = "feet";
                    DoTheConversion(mToInchesRatio, FromMeasurementTypeText, ToMeasurementTypeText);
                    break;
                case 2:
                    FromMeasurementTypeText = "degrees celcius";
                    ToMeasurementTypeText = "degrees fahrenheit";
                    DoTheConversion(celciusToFHeitRatio, FromMeasurementTypeText, ToMeasurementTypeText, 32);
                    break;
                case 3:
                    FromMeasurementTypeText = "centimetres";
                    ToMeasurementTypeText = "feet";
                    DoTheConversion(cmToFeetRatio, FromMeasurementTypeText, ToMeasurementTypeText);
                    break;
                case 4:
                    FromMeasurementTypeText = "kilometres";
                    ToMeasurementTypeText = "miles";
                    DoTheConversion(kmToMilesRatio, FromMeasurementTypeText, ToMeasurementTypeText);
                    break;
                default:
                    message = "That selection is not valid";
                    MessageBox.Show(message);
                    break;
            }
        }
    }
}