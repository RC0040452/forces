﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double sin(double x)
            {
            return (Math.Sin(x * Math.PI / 180.00));
                    }
            double asin(double x)
            {
            return (Math.Asin(x) * 180 / Math.PI);
            }

            double cos(double x)
            {
                return (Math.cos(x * Math.PI / 180.00));
            }
            double acos(double x)
            {
                return (Math.Acos(x) * 180 / Math.PI);
            }


        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
