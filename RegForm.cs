using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class RegForm : Form
    {
        private SqlConnection conn = new BdConn().conn;
        public RegForm()
        {
            InitializeComponent();
            textBox3.PasswordChar = '●';
            textBox2.PasswordChar = '●';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Authentication fr = new Authentication();
            fr.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string pwd = textBox2.Text;
            SqlCommand cmd = new SqlCommand($"insert into Клиенты(PhoneNumber, Password, Employee) values ('{number}', N'{pwd}', 'False') ", conn);

            if(pwd == textBox3.Text)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Регистрация прошла успешно!");
                MainWindow MainForm = new MainWindow();
                MainForm.Show();
                Close();
            }
            else { MessageBox.Show("Пароли не совпадают!"); }
        }
    }
}
