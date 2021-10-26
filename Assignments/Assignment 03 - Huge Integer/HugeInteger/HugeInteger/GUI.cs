using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugeInteger
{
    public partial class GUI : Form
    {

        private HugeInteger h1;
        private HugeInteger h2;

        public GUI()
        {
            InitializeComponent();
        }

        private Boolean IsValidInput(String input)
        {
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
                if (!Char.IsDigit(charArray[i]))
                    return false;
            return true;
        }

        private void ShowErrorMessage(String message)
        {
            MessageBox.Show("Warning: " + message,
                "Attention", 0, MessageBoxIcon.Warning); 
        }

        private void RefreshInput()
        {
            input1TextBox.Text = string.Empty;
            input2TextBox.Text = string.Empty;
            clearRadioButtons();
        }

        private void input1TextBox_Click(object sender, EventArgs e)
        {
            if (input1TextBox.Text.Equals("Enter a number"))
                input1TextBox.Text = string.Empty;
        }

        private void input2TextBox_Click(object sender, EventArgs e)
        {
            if (input2TextBox.Text.Equals("Enter a number"))
                input2TextBox.Text = string.Empty;
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (!IsValidInput(input1TextBox.Text) || !IsValidInput(input2TextBox.Text))
            {
                ShowErrorMessage("Only digits are accepted as input. Please enter valid input.");
                RefreshInput();
            }
            else
            {
                h1 = new HugeInteger(input1TextBox.Text);
                h2 = new HugeInteger(input2TextBox.Text);
                displayLabel.Text = h1.Add(h1, h2).ToString();
            }
            checkRadioButtons(); //automatically compares numbers and checks radio buttons accordingly
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            if (!IsValidInput(input1TextBox.Text) || !IsValidInput(input2TextBox.Text))
            {
                ShowErrorMessage("Only digits are accepted as input. Please enter valid input.");
                RefreshInput();
            }
            else
            {
                h1 = new HugeInteger(input1TextBox.Text);
                h2 = new HugeInteger(input2TextBox.Text);
                displayLabel.Text = h1.Subtract(h1, h2).ToString();
            }
            checkRadioButtons(); //automatically compares numbers and checks radio buttons accordingly
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkRadioButtons()
        {
            h1 = new HugeInteger(input1TextBox.Text);
            h2 = new HugeInteger(input2TextBox.Text);

            if (h1.IsEqualTo(h1, h2))
                isEqualToRadioButton.Checked = true;
            if (h1.IsNotEqualTo(h1, h2))
                isNotEqualToRadioButton.Checked = true;
            if (h1.IsGreaterThan(h1, h2))
                isGreaterThanRadioButton.Checked = true;
            if (h1.IsLessThan(h1, h2))
                isLessThanRadioButton.Checked = true;
            if (h1.IsGreaterThanOrEqualTo(h1, h2))
                isGreaterThanOrEqualToRadioButton.Checked = true;
            if (h1.IsLessThanOrEqualTo(h1, h2))
                isLessThanOrEqualToRadioButton.Checked = true;
        }

        private void clearRadioButtons()
        {
            isEqualToRadioButton.Checked = false;
            isNotEqualToRadioButton.Checked = false;
            isGreaterThanRadioButton.Checked = false;
            isLessThanRadioButton.Checked = false;
            isGreaterThanOrEqualToRadioButton.Checked = false;
            isLessThanOrEqualToRadioButton.Checked = false;
        }


    }
}
