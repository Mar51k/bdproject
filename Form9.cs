using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdproject
{
    public partial class Authentication : Form
    {
        private SqlConnection conn = new BdConn().conn;
        public Authentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            SqlCommand auth = new SqlCommand($"select PhoneNumber, Password from Клиенты where (PhoneNumber = '{login}') and (Password = '{password}')", conn);
            SqlDataReader reader = auth.ExecuteReader();
            if (reader != null)
            {
                MessageBox.Show("Авторизация прошла успешно!");
                Form2 frm = new Form2();
                frm.Show();
                Close();
            }
            else { MessageBox.Show("Неверный номер телефона или пароль!"); }
        }
    }
}
