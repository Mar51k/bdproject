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
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupportChatForm supportChatForm = new SupportChatForm();
            supportChatForm.ShowDialog();
        }
    }
}
