﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonsTest
{
    public partial class RadioButtonsTestForm : Form
    {

        private MessageBoxIcon IconType { get; set; }
        private MessageBoxButtons ButtonType { get; set; }

        public RadioButtonsTestForm()
        {
            InitializeComponent();
        }

        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == okRadioButton)
                ButtonType = MessageBoxButtons.OK;

            else if (sender == okCancelRadioButton)
                ButtonType = MessageBoxButtons.OKCancel;

            else if (sender == abortRetryIgnoreRadioButton)
                ButtonType = MessageBoxButtons.AbortRetryIgnore;

            else if (sender == yesNoCancelRadioButton)
                ButtonType = MessageBoxButtons.YesNoCancel;

            else if (sender == yesNoRadioButton)
                ButtonType = MessageBoxButtons.YesNo;

            else
                ButtonType = MessageBoxButtons.RetryCancel;
        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == asteriskRadioButton)
                IconType = MessageBoxIcon.Asterisk;

            else if (sender == errorRadioButton)
                IconType = MessageBoxIcon.Error;

            else if (sender == exclamationRadioButton)
                IconType = MessageBoxIcon.Exclamation;

            else if (sender == handRadioButton)
                IconType = MessageBoxIcon.Hand;

            else if (sender == informationRadioButton)
                IconType = MessageBoxIcon.Information;

            else if (sender == questionRadioButton)
                IconType = MessageBoxIcon.Question;

            else if (sender == stopRadioButton)
                IconType = MessageBoxIcon.Stop;

            else
                IconType = MessageBoxIcon.Warning;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This is your Custom MessageBox.",
                "Custom MessageBox", ButtonType, IconType);

            switch (result)
            {
                case DialogResult.OK:
                    displayLabel.Text = "OK was pressed.";
                    break;
                case DialogResult.Cancel:
                    displayLabel.Text = "Cancel was pressed.";
                    break;
                case DialogResult.Abort:
                    displayLabel.Text = "Abort was pressed.";
                    break;
                case DialogResult.Retry:
                    displayLabel.Text = "Retry was pressed.";
                    break;
                case DialogResult.Ignore:
                    displayLabel.Text = "Ignore was pressed.";
                    break;
                case DialogResult.Yes:
                    displayLabel.Text = "Yes was pressed.";
                    break;
                case DialogResult.No:
                    displayLabel.Text = "No was pressed.";
                    break;
            }
        }
    }
}
