// Author: Jonathan Spalding
// Assignment: Project 01
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 1/23/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The aboutToolStripMenuItem_Clic Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding/nCS1400/Project 1");
        }
        // I accidentally clicked on the input text box and forgot to create the "Leave" method. It doesn't let me edit this argument to have _leave or even delete it.
        private void mealAmountInput_TextChanged(object sender, EventArgs e)
        {

        }
        // The mealAmountInput_Leave Method
        // Purpose: take the cost of the meal, and give three outputs for poor, average, and excellent service. It converts the input from a string to a double, then multiplies it by the percentages to get the proper tips, then converts all three outputs into strings, and places it in the proper output boxes.
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void mealAmountInput_Leave(object sender, EventArgs e)
        {
            // I didn't make constants because I figured it's pointless when each constant is only used once. But I understand the benefit of having a constant in a larger program. Also the Interface requirements didn't say I needed constants, just to "See lab #5."
            double num = double.Parse(mealAmountInput.Text);
            double poorService = num * .1;
            double averageService = num * .15;
            double excellentService = num * .2;
            string poorServiceOutStr = $"{poorService:c}";
            string averageServiceOutStr = $"{averageService:c}";
            string excellentServiceOutStr = $"{excellentService:c}";
            poorServiceOutput.Text = poorServiceOutStr;
            averageServiceOutput.Text = averageServiceOutStr;
            excellentServiceOutput.Text = excellentServiceOutStr;
        }
    }
}
