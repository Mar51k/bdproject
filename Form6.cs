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
    public partial class Staff_onUser : Form
    {
        public Staff_onUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Close();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupportForm sup = new SupportForm();
            sup.ShowDialog();
        }

        private void петеводительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityFinder city = new CityFinder();
            city.Show();
            Close();
        }

        private void кToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
            Close();
        }
    }
}
