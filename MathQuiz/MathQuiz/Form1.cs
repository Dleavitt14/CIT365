using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer to generate random numbers.
        Random randomizer = new Random();

        // These variables will hold the values for the addition problem.
        int addend1;
        int addend2;

        // Start the quiz by filling in all of the problems and starting the timer.

        public void StartTheQuiz()
        {
            // Fill in the addition problems.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'
            addend1 = randomizer.Next(51);
            addend1 = randomizer.Next(51);

            // Convert the two randomly generated numbers into strings so that they
            // can be displayed in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control. This step makes sure
            // its value is zero before adding any values to it.
            sum.Value = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }
    }
}
