using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppForm f2 = new AppForm();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using Word to PDF Converter");
            System.Windows.Forms.Application.Exit();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            Size screenSize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screenSize.Width / 2 - Width / 2, screenSize.Height / 2 - Height / 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mailAuth ma = new mailAuth();
            ma.Show();
        }
    }
}
