using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            //using regex to only match numbers(negative and positive)
            Regex rx = new Regex("^-?[0-9]+$");
            if (rx.IsMatch(input))
                return true;

            return false;
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

            clearRadioButtons();
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

            clearRadioButtons();
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
                isEqualToCheckBox.Checked = true;

            if (h1.IsNotEqualTo(h1, h2))
                isNotEqualToCheckBox.Checked = true;

            if (h1.IsGreaterThan(h1, h2))
                isGreaterThanCheckBox.Checked = true;

            if (h1.IsLessThan(h1, h2))
                isLessThanCheckBox.Checked = true;

            if (h1.IsGreaterThanOrEqualTo(h1, h2))
                isGreaterThanOrEqualToCheckBox.Checked = true;

            if (h1.IsLessThanOrEqualTo(h1, h2))
                isLessThanOrEqualToCheckBox.Checked = true;
        }

        private void clearRadioButtons()
        {
            isEqualToCheckBox.Checked = false;
            isNotEqualToCheckBox.Checked = false;
            isGreaterThanCheckBox.Checked = false;
            isLessThanCheckBox.Checked = false;
            isGreaterThanOrEqualToCheckBox.Checked = false;
            isLessThanOrEqualToCheckBox.Checked = false;
        }
    }
}
