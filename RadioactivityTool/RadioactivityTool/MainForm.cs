using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RadioactivityTool
{
    public partial class EffectInfo : Form
    {
        public String SelectedRadiationType;
        public Double MultiplicationEffectNumber;
        public String DoseEffect;
        public Double GrayValue;
        public EffectInfo()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Any requirements if needed
            // Done setting up the form
        }
        public void LoadDamages(double RadiationDoseInput, string DoseEffect)
        {
            // Create dictionairy with mSv values. 31 positions total.
            IDictionary<double, string> dict = new Dictionary<double, string>();
            // Insert data into the dictionairy.
            dict.Add(0.1, "Instant Exposure: Eating a banana.");
            dict.Add(0.25, "Instant Exposure: Maximum allowed at a security scan.");
            dict.Add(1.0, "After 1 year: Using a CRT computer monitor for a year.");
            dict.Add(5.0, "Instant Exposure: Dental X-ray");
            dict.Add(7.5, "After 1 day: Being 250km away from the Fukushima plant, 107 days after disaster.");
            dict.Add(10.0, "After 1 day: Average dose per person per day. (varies wildly)");
            dict.Add(40.0, "After 1 day: Flight from NY to LA");
            dict.Add(50.0, "After 1 day: Dose from standing on the floor of Chernobyl in 2010.");
            dict.Add(70.0, "After 1 year: Dose after living in a stone or concrete house for a full year.");
            dict.Add(80.0, "After 1 year: Average dose per person living 10 miles from the 1979 Three Mile Island accident.");
            dict.Add(100.0, "After 1 hour: Dose 2km south west from the Fukushima plant. (83 days after disaster.)");
            dict.Add(250.0, "After 1 year: Release limit for a nuclear power plant per person.");
            dict.Add(400, "After 1 year: Dose per person per year from eating food. Instant Exposure: Mammogram.");
            dict.Add(1000, "Instant Exposure (sort of): US Radiation limit on artificial radiation exposure to a member of the public.");
            dict.Add(1500, "Instant Exposure: Spinal X-Ray. After 1 hour: Exposure detected at Fukushima site. (1 day after disaster.) ");
            dict.Add(2400, "After 1 year: Average dose of natural background radiation per person per year.");
            dict.Add(10000, "Instant Exposure: Average CT Scan.");
            dict.Add(36000, "After 1 year: Smoking 1.5 packs of sigarettes per day.");
            dict.Add(50000, "Instant Exposure: Maximum yearly dose permitted for US radiation workers.");
            dict.Add(100000, "After 1 year: Lowest annual dose where increased lifetime risk of cancer is evident.");
            dict.Add(250000, "Instant Exposure: Maximum radiation dose limit for workers in life-saving operations. (US)");
            dict.Add(400000, "After 1 hour: Maximum radiation levels detected at Fukushima");
            dict.Add(500000, "After 1 day: Slight decrease in blood cell counts returning to normal in a few days.");
            dict.Add(1000000, "After 1 day: Temporary radiation sickness. Nausea, low blood cell count. Not fatal. Per hour surface water in tunnels outside Fukushima no2 reactor.");
            dict.Add(2000000, "Instant Exposure: Highly targeted dose used in radiotherapy. After 1 day: Found near Fukushima tanks, (Aug. 2013)");
            dict.Add(4000000, "After 1 day: Extremely servere dose. Bleeding, hair loss. Death possible within 4-6 weeks.");
            dict.Add(6000000, "After 1 day: Usually fatal within 2-4 weeks if untreated.");
            dict.Add(10000000, "After 1 day: Fatal dose, death within 2 weeks.");
            dict.Add(30000000, "After 1 day: Seizures & tremors.Death within 48 hours.");
            dict.Add(50000000, "10 mins after the exposure to the Chernobyl reactor core after meltdown.");
            dict.Add(932966366, "After 1 hour: Exposure to The Elephant's Foot. The most radioactive substance known to mankind. Created by the meltdown of Chernobyl.");

            // Determine closest match of the dictionairy by key.
            // e is the effect string.
            var bestMatch = dict.OrderBy(e => Math.Abs(e.Key - RadiationDoseInput)).FirstOrDefault();
            Console.WriteLine("Input: " + RadiationDoseInput + " // Closest result: " + bestMatch);
            // Display result in the GUI
            EffectBox.Text = bestMatch.Value;
            DoseEffect = bestMatch.Key.ToString();
            ResultListBox.Text = DoseEffect;
            // Also show the result in mSv on the GUI
            textBoxCalculation.Text = RadiationDoseInput.ToString();
            // Inform user
            RunButton.Text = "Done! Open the Output tab.";
        }

        public void DetermineDamages(double DamagesDicInput)
        {
            // NOTE: INPUT MUST ALWAYS BE CONVERTED TO MICROSIEVERTS.
            // Return given value and turn it into mSv for determination.
            if (this.SelectedRadiationType == "Sievert") // Run this part only if the given dose is Sievert.
            {
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Micro") // No conversion needed for determination.
                {
                    LoadDamages((double)InputUpDownBox.Value, ""); // In this part, Micro is the wanted value. Thus the further we go, we need to multiply.
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Milli")
                {
                    LoadDamages((1000 * (double)InputUpDownBox.Value), ""); // Increment input from here by 10.                  
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Centi")
                {
                    LoadDamages((10000 * (double)InputUpDownBox.Value), "");
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Deci")
                {
                    LoadDamages((100000 * (double)InputUpDownBox.Value), "");
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Absolute")
                {
                    LoadDamages((1000000 * (double)InputUpDownBox.Value), "");
                }
            }
            if (this.SelectedRadiationType == "Gray")
            { // Do the same as above, just with different inputs.

                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Micro") // No conversion needed for determination.
                {
                    LoadDamages(DamagesDicInput, ""); // In this part, Micro is the wanted value. Thus the further we go, we need to multiply.
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Milli")
                {
                    LoadDamages(1000 * DamagesDicInput, ""); // Increment input from here by 10.                  
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Centi")
                {
                    LoadDamages((10000 * DamagesDicInput), "");
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Deci")
                {
                    LoadDamages((100000 * DamagesDicInput), "");
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Absolute")
                {
                    LoadDamages((1000000 * DamagesDicInput), "");
                }
            }
            if (this.SelectedRadiationType == "Roentgen")
            {  // Do the same as above, just with different inputs.
                // Thus, the function BeginCalculations first starts to convert to Sieverts, multiply it by its atom type, then return it here.

                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Micro") // No conversion needed for determination.
                {
                    LoadDamages(DamagesDicInput, ""); // In this part, Micro is the wanted value. Thus the further we go, we need to multiply.
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Milli")
                {
                    LoadDamages(1000 * DamagesDicInput, ""); // Increment input from here by 10.                  
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Centi")
                {
                    LoadDamages((10000 * DamagesDicInput), "");
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Deci")
                {
                    LoadDamages((100000 * DamagesDicInput), "");
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Absolute")
                {
                    LoadDamages((1000000 * DamagesDicInput), "");
                }
            }
        }

        public void BeginCalulations()
        {
            // To convert Gray to Sievert: Grab the radiation type and multiply it by its determined factor.
            // To convert Roentgen to Sievert: 1 roentgen  =  0.0093296637 sievert 

            //Determine type given and display damages
            if (SelectedRadiationType == "Gray")
            { // This is a different type of radiation. One must convert it and take the extra radiation types into effect as well.
                // This is required because some types of nuclei damage living being more then others.

                // Take the input, and multiply it based to its atom type input:
                Double PreGrayValue = (double)InputUpDownBox.Value;
                if (string.IsNullOrEmpty(atomTypeBox.Text)) // Check if the desired atom type has been selected before starting.
                {
                    MessageBox.Show("When using Gray, select the radation type too!");
                }
                else
                {
                    if (atomTypeBox.Text.ToString() == "Beta, Gamma and X-rays")
                    { // Multiply by 1.
                        GrayValue = PreGrayValue * 1;
                    }
                    if (atomTypeBox.Text.ToString() == "Thermal Neutrons")
                    { // Multiply by 3.
                        GrayValue = PreGrayValue * 3;
                    }
                    if (atomTypeBox.Text.ToString() == "Fast n, a, and protons")
                    { // Multiply by 10.
                        GrayValue = PreGrayValue * 10;
                    }
                    if (atomTypeBox.Text.ToString() == "Heavy and recoil nuclei")
                    { // Multiply by 20.
                        GrayValue = PreGrayValue * 20;
                    }
                    Console.WriteLine("Gray value with atom damages: " + GrayValue);
                    DetermineDamages(this.GrayValue);
                }
            }
            if (SelectedRadiationType == "Sievert")
            { // This is already in Sieverts, no conversion required. Run the function directly.
                DetermineDamages(0); // The given value may be 0. Because the function itself also performs checks.
            }
            if (SelectedRadiationType == "Roentgen")
            { // This is a different type of radiation. One must convert it and take the extra radiation types into effect as well.
                Double RoentgenMultiplier = 0.0093296637; // Store base value.
                Double RoentgenToSievertsResult = (double)InputUpDownBox.Value * RoentgenMultiplier; // Convert Roentgen to Sieverts as absolute.
                Console.WriteLine("Roentgen to Sievert result = " + RoentgenToSievertsResult); // Give output about the result.
                DetermineDamages(RoentgenToSievertsResult); // Send result to the DetermineDamages function to let it calculate the result.
            }
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            // Save and store the selected dosemitry unit.
            if (radiationtypeRadioButton1.Checked)
            { // Gray
                this.SelectedRadiationType = (radiationtypeRadioButton1.Text.ToString());
            }
            else if (radiationtypeRadioButton2.Checked)
            { // Sieverts
                this.SelectedRadiationType = (radiationtypeRadioButton2.Text.ToString());
            }
            else if (radiationtypeRadioButton3.Checked)
            { // Roentgen
                this.SelectedRadiationType = (radiationtypeRadioButton3.Text.ToString());
            }
            Console.WriteLine("Type updated to: " + SelectedRadiationType);
            // Continue

            if (string.IsNullOrEmpty(comboboxDose.Text)) // Check if the user has selected a dose before starting.
            {
                MessageBox.Show("Select your radiation dose first!");
            }
            else
            {
                Console.WriteLine("Now beginning to process input.");
                Console.WriteLine("Started input type: " + SelectedRadiationType + " // Value: " + InputUpDownBox.Text);
                // Determine multiplication
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Micro")
                {
                    MultiplicationEffectNumber = 0.000001;
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Milli")
                {
                    MultiplicationEffectNumber = 0.001;
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Centi")
                {
                    MultiplicationEffectNumber = 0.01;
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Deci")
                {
                    MultiplicationEffectNumber = 0.1;
                }
                if (comboboxDose.GetItemText(comboboxDose.SelectedItem) == "Absolute")
                {
                    MultiplicationEffectNumber = 1;
                }

                // Convert the set dose to the main value
                double d = (double)InputUpDownBox.Value; // Cast it into a double for floating point calculations            
                d = d * MultiplicationEffectNumber; // Multiply by the set dose
                Console.WriteLine("Input: " + d + " " + SelectedRadiationType); // Give feedback on console.

                //DetermineDamages(0);// Start the calculations, determinations and other processes.
                BeginCalulations();
            }
        }

        private void comboboxDose_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunButton.Text = "Go!";
        }

        private void atomTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunButton.Text = "Go!";

        }

        private void InputUpDownBox_ValueChanged(object sender, EventArgs e)
        {
            RunButton.Text = "Go!";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}