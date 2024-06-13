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
        public static bool empl { get; set; } = false;
        private SqlConnection conn = new BdConn().conn;
        public Authentication()
        {
            InitializeComponent();
            textBox2.PasswordChar = '●';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            SqlCommand auth = new SqlCommand($"select PhoneNumber, Password, Employee from Клиенты where (PhoneNumber = '{login}') and (Password = '{password}') ", conn);
            
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = auth;
            adapter.Fill(dt);
            string sql = "";

            try
            {
                DataSet ss = new DataSet();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                adapter1.SelectCommand = auth;
                adapter1.Fill(ss);
                sql = ss.Tables[0].Rows[0]["Employee"].ToString();
            }
            catch(Exception ex)
            {
                
            }
            
            
            

            

            //MessageBox.Show(sql);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Авторизация прошла успешно!");
                if(sql == "True")
                {
                    Authentication.empl = true;
                }
                MainWindow frm = new MainWindow();
                frm.Show();
                Close();
            }
            else { MessageBox.Show("Неверный номер телефона или пароль!"); }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegForm fr10 = new RegForm();
            fr10.Show();
            Close();
        }
    }
}


