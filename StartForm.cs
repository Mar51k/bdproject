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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 51, 51);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AuthForm form3 = new AuthForm();
            form3.Show();
            Hide();

        }
    }
}
