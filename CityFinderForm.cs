using System;
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
    public partial class CityFinder : Form
    {
        public CityFinder()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupportForm supportForm = new SupportForm();
            supportForm.ShowDialog();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow form2 = new MainWindow();
            form2.Show();
            Close();
        }

        private void кToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MoscowForm form8 = new MoscowForm();
            form8.ShowDialog();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Authentication.empl == true)
            {
                Staff_onStaff frm = new Staff_onStaff();
                frm.Show();
                Close();
            }
            else
            {
                Staff_onUser fr2 = new Staff_onUser();
                fr2.Show();
                Close();
            }
        }
    }
}
