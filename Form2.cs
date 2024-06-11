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
using Microsoft.SqlServer.Server;

namespace bdproject
{
    public partial class Form2 : Form
    {
        private SqlConnection conn = new BdConn().conn;
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 51, 51);
            dataGridView1.BackgroundColor = Color.FromArgb(51, 51, 51);

            departure_date.Format = DateTimePickerFormat.Custom;
            departure_date.CustomFormat = "yyyy-MM-dd";
            arrival_date.Format = DateTimePickerFormat.Custom;
            arrival_date.CustomFormat = "yyyy-MM-dd";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void seacrhbutton_Click(object sender, EventArgs e)
        {
            string From = FromBox.Text;
            string Where = WhereBox.Text;
            string count = HumanCounter.Text;
            string ticket = TicketType.Text;
            string start = departure_date.Text;
            string end = arrival_date.Text;

            MessageBox.Show($"{end} ++ {start}");

            //SqlCommand find = new SqlCommand($"select Route, DateStart, DateEnd from Рейсы where Route LIKE N'{start}-{end}' ", conn);
            //SqlDataReader reader = find.ExecuteReader();
            
            SqlDataAdapter adapter = new SqlDataAdapter($"select Route, DateStart, DateEnd from Рейсы where (Route LIKE N'%{From}-{Where}%') and (DateStart LIKE '{start}') and (DateEnd LIKE '{end}') ", conn);
            DataSet ds = new DataSet();

            //DataTable dt = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            
        }

        private void FromBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupportForm sp = new SupportForm();
            sp.ShowDialog();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void петеводительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityFinder cit  = new CityFinder();
            cit.Show();
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
