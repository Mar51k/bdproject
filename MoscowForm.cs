using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdproject
{
    
    public partial class MoscowForm : Form
    {
        private SqlConnection conn = new BdConn().conn;
        public MoscowForm()
        {
            InitializeComponent();
            SqlDataAdapter adapter = new SqlDataAdapter($"select Route, DateStart, DateEnd from Рейсы where Route LIKE N'%Москва%' ", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
