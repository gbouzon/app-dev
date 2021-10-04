﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxPanelExample
{
    public partial class GroupBoxPanelExample : Form
    {
        public GroupBoxPanelExample()
        {
            InitializeComponent();
        }

        private void hiButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi pressed";
        }

        private void byeButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Bye pressed";
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Left pressed";
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Far Right pressed";
        }
    }
}
