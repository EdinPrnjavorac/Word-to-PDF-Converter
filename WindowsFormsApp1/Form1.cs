using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Login()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BST144;Initial Catalog=logindb;Integrated Security=True";

            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BST144;Initial Catalog=logindb;Integrated Security=True";
            con.Open();
            string username = textBox1.Text;
            string password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("SELECT username,password FROM users WHERE username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess ");

                AppForm m = new AppForm();
                m.Show();
                this.Hide();
                m.Show();


            }
            else
            {
                MessageBox.Show("Invalid Login, please check username and password");
                textBox1.Clear();
                textBox2.Clear();

            }
            con.Close();

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void passwordtxt_Click(object sender, EventArgs e)
        {

        }


        private void registerbtn_Click_1(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Size screenSize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screenSize.Width / 2 - Width / 2, screenSize.Height / 2 - Height / 2);
        }
    }
}
