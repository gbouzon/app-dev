﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxTest
{
    public partial class PictureBoxTestForm : Form
    {
        private int ImageNumber { get; set; } = -1;
        public PictureBoxTestForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            imagePictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"image{ImageNumber}"));
        }
    }
}
