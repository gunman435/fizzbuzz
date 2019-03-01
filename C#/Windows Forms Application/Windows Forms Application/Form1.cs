using System;
using System.Windows.Forms;

namespace Windows_Forms_Application
{
    public partial class Window : Form
    {
        /// <summary>
        /// Default Configuration
        /// </summary>
        int[] factors = new int[] { 3, 5 };

        string[] factorWords = new string[] { "Fizz", "Buzz" };

        int maxNumber = 100;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            // Run the fizz buzz test at the start
            FizzBuzz();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Split the factors
            string[] factorStrings = factorsTextBox.Text.Split(',');
            factors = new int[factorStrings.Length];
            
            // Parse the factors into integers for use
            for (int i = 0; i < factors.Length; i++)
            {
                int.TryParse(factorStrings[i], out factors[i]);
            }

            // Split the factor words and put them into the array
            factorWords = factorWordsTextBox.Text.Split(',');

            // Parse the number text and place it into the max number variable
            int.TryParse(maxNumberTextBox.Text, out maxNumber);

            // Run the fizz buzz test with the new variables
            FizzBuzz();
        }

        void FizzBuzz()
        {
            // Reset the rich text box
            outputRichTextBox.Text = "";

            string[] newText = new string[maxNumber];

            for (int i = 1; i <= maxNumber; i++)
            {
                string line = "";

                // Test for the factors provided and apply the words that are needed
                for (int i2 = 0; i2 < factors.Length; i2++)
                {
                    if (i % factors[i2] == 0)
                        line += factorWords[i2];
                }

                // Check if there are no factors applied for this number.
                // If so, set the line to the number
                if (line == "")
                    line = i.ToString();

                // Write our final product to the line array
                newText[i - 1] = line;
            }

            // Update the text box with our new text
            outputRichTextBox.Lines = newText;
        }
    }
}
