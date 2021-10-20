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
    public partial class HugeInteger : Form
    {
        public HugeInteger()
        {
            InitializeComponent();
        }

        private void num1TextBox_Click(object sender, EventArgs e)
        {
            num1TextBox.Text = string.Empty;
            //removing action after first click so that it doesn't erase info if it's clicked again
            num1TextBox.Click -= num1TextBox_Click; 
        }

        private void num2TextBox_Click(object sender, EventArgs e)
        {
            num2TextBox.Text = string.Empty;
            //removing action after first click so that it doesn't erase info if it's clicked again
            num2TextBox.Click -= num2TextBox_Click; 
        }
    }
}
