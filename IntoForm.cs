﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdproject
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication frm = new Authentication();
            frm.Show();
            Close();
        }

        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
