using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class toMoSpending : Form
    {
        string Budget = "";
        double dbudget = 0;
        double budNum = 0;
        double percentage = 0;
        double spent = 0;
        int iPercent = 0;
        public toMoSpending()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lv_spendings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void vBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void eIn_Click(object sender, EventArgs e)
        {
            Budget = txtIn.Text;
            dbudget = double.Parse(Budget); // text to double type
            expectF.Text = "$" + Budget;
            budNum = double.Parse(Budget);
            percentage = Math.Truncate((dbudget / budNum) * 100);
            iPercent = Convert.ToInt32(percentage);
            vBar1.Value = iPercent;
            pcent.Text =  percentage.ToString() + "%";
        }

        private void eDnP_Click(object sender, EventArgs e)
        {
            spent = double.Parse(txtCost.Text);
            dbudget = dbudget - spent;

            Budget = dbudget.ToString();

            ListViewItem Item = new ListViewItem(txtName.Text);
    
            Item.SubItems.Add(txtCost.Text);
            Item.SubItems.Add(Budget);
            lv_spendings.Items.Add(Item);

            //budNum = double.Parse(Budget);
            expectF.Text = "$" + dbudget;

            percentage = Math.Truncate((dbudget / budNum) * 100);
            iPercent = Convert.ToInt32(percentage);
            vBar1.Value = iPercent;
            pcent.Text = percentage.ToString() + "%";

            vBar1.Update();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void txtIn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                lv_spendings.SelectedItems[0].SubItems[0].Text = txtName.Text;
            }

            if (txtCost.Text != "")
            {
                spent = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                dbudget = dbudget + spent;
                // add back previous value
                lv_spendings.SelectedItems[0].SubItems[1].Text = txtCost.Text;

                spent = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                dbudget = dbudget - spent;
                //subtract updated value

                Budget = dbudget.ToString();

                lv_spendings.SelectedItems[0].SubItems[2].Text = Budget;

                btnEnter.PerformClick();

            }
            

        }

        private void lv_spendings_MouseClick(object sender, MouseEventArgs e)
        { 
            txtName.Text = lv_spendings.SelectedItems[0].SubItems[0].Text;
            txtCost.Text = lv_spendings.SelectedItems[0].SubItems[1].Text;
        }
    }
}
