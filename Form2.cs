using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace bdproject
{
    public partial class Form2 : Form
    {
        private SqlConnection conn = null;
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 51, 51);
            dataGridView1.BackgroundColor = Color.FromArgb(51, 51, 51);
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=DESKTOP-E9RKKNE\\SQLEXPRESS;Initial Catalog=&quot;airport 23.106 kretinin mamaev&quot;;Integrated Security=True;Encrypt=False"].ConnectionString);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Support_Click(object sender, EventArgs e)
        {
            SupportForm sp = new SupportForm();
            sp.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void seacrhbutton_Click(object sender, EventArgs e)
        {

        }

        private void FromBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
