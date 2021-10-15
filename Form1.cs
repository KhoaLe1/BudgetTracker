using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
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

            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            } 
            else if (checkBox1.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true) {txtPassword.UseSystemPasswordChar = false;}
            else { txtPassword.UseSystemPasswordChar = true;}
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
