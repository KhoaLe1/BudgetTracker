using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class toDashboard : Form
    {
        public toDashboard()
        {
            InitializeComponent();
            this.ActiveControl = textBox2;
            textBox2.Focus();

        }

        private void toDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Balance = double.Parse(textBox2.Text);
            double Income = double.Parse(textBox3.Text);
            double NetWorth = Balance + Income;
            double Goal = double.Parse(textBox4.Text);


            string MGoal = Goal.ToString();
            string Bank = Balance.ToString();
            string NW = NetWorth.ToString();

            label1.Text = NW;
            label2.Text = Bank;
            MoneyGoal.Text = MGoal;

            vBar1.Update();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) 
            { e.Handled = true; }
            
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }

        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vBar1_Click(object sender, EventArgs e)
        {
            double Balance = double.Parse(textBox2.Text);
            double Income = double.Parse(textBox3.Text);
            double NetWorth = Balance + Income;
            double Goal = double.Parse(textBox4.Text);
            int percentage = Convert.ToInt32( (NetWorth / Goal) * 100);
            vBar1.Value = percentage;
            pcent.Text = percentage.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
