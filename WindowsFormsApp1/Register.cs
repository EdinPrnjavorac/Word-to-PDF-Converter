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


namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection();

        public Register()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != textBox1.Text)
            {
                MessageBox.Show("Passwords do not match.");
                textBox1.Clear();
                textBox2.Clear();
            }

            else { 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=BST144;Initial Catalog=logindb;Integrated Security=True";
            con.Open();
            string username = textBox1.Text;
            string password = textBox2.Text;

            
                SqlCommand cmd = new SqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully registered.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Size screenSize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screenSize.Width / 2 - Width / 2, screenSize.Height / 2 - Height / 2);
        }
    }
}
