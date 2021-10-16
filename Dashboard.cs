using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BudgetTracker
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            this.ActiveControl = TextBox2;
            TextBox2.Focus();
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double Balance = double.Parse(TextBox2.Text);
            double NetWorth = Balance;
            double Goal = double.Parse(TextBox4.Text);


            string MGoal = Goal.ToString();
            string Bank = Balance.ToString();
            string NW = NetWorth.ToString();

            Label1.Text = NW;
            Label2.Text = Bank;
            MoneyGoal.Text = MGoal;

            int percentage = Convert.ToInt32((NetWorth / Goal) * 100);
            VBar1.Value = percentage;
            pcent.Text = percentage.ToString();
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { e.Handled = true; }
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void VBar1_Click(object sender, EventArgs e)
        {

        }

        private void MoneyGoal_Click(object sender, EventArgs e)
        {

        }
    }
}

