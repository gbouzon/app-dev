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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input1TextBox_Click(object sender, EventArgs e)
        {
            if (input1TextBox.Text.Equals("Enter a number"))
                input1TextBox.Text = string.Empty;
            //removing action after first click so that it doesn't erase user input if it's accidentally clicked again
            input1TextBox.Click -= input1TextBox_Click;
        }

        private void input2TextBox_Click(object sender, EventArgs e)
        {
            if (input1TextBox.Text.Equals("Enter a number"))
                input2TextBox.Text = string.Empty;
            //removing action after first click so that it doesn't erase user input if it's accidentally clicked again
            input2TextBox.Click -= input2TextBox_Click;
        }
    }
}
