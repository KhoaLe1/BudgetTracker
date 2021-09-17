using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "khoale177" && txtPassword.Text == "nup6rtqb")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or password you have entered is incorrect, please try again.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
