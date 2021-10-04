using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxTest
{
    public partial class CheckBoxTestForm : Form
    {
        public CheckBoxTestForm()
        {
            InitializeComponent();
        }

        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //the operator ^ (logical exclusive OR) allows us to combine choices for the checkbox
            //dynamically change as the choices change
            //note the difference if we were to use | (logical OR) instead of ^
            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}
