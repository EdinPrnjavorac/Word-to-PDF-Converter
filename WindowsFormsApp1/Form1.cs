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

namespace WordToPDFConverter
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtusernamelogin.Text) && !String.IsNullOrEmpty(txtpasswordlogin.Text))
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=BST144;Initial Catalog=logindb;Integrated Security=True";
                con.Open();
                string username = txtusernamelogin.Text;
                string password = txtpasswordlogin.Text;
                SqlCommand cmd = new SqlCommand("SELECT username,password FROM users WHERE username='" + txtusernamelogin.Text + "'and password='" + txtpasswordlogin.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Login sucess ");

                    AppForm m = new AppForm();
                    this.Hide();
                    m.Show();


                }
                else
                {
                    MessageBox.Show("Invalid Login, please check username and password");
                    txtusernamelogin.Clear();
                    txtpasswordlogin.Clear();

                }
                con.Close();

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click_1(object sender, EventArgs e)
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
