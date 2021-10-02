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
        string Budget = "", updated = "";
        double dbudget = 0;
        double budNum = 0;
        double percentage = 0;
        double spent = 0;
        int iPercent = 0;
        bool update = false;
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
            if (MessageBox.Show("Warning: This will clear all inputed data. Do you want to continue?", "CLEAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
                lv_spendings.Items.Clear();
                updated = "0";
                Budget = "0";
                iPercent = 0;
                update = false;
                btnEnter.PerformClick();
            }
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

            if (txtIn.Text != "") { Budget = txtIn.Text; }
            txtIn.Text = "";
            if(update == false) 
            { 
                dbudget = double.Parse(Budget); // text to double type
                expectF.Text = "$" + Budget;
                budNum = double.Parse(Budget);
            } else if (update == true)
            {
                expectF.Text = "$" + updated;
            }

            percentage = Math.Truncate((dbudget / budNum) * 100);
            if (dbudget != 0) { iPercent = Convert.ToInt32(percentage); }
            else { iPercent = 0; }
            vBar1.Value = iPercent;
            pcent.Text = percentage.ToString() + "%";
        }

        private void eDnP_Click(object sender, EventArgs e)
        {
            if (txtCost.Text == "") { txtCost.Text = "0"; } 
            spent = double.Parse(txtCost.Text);
            dbudget = dbudget - spent;

            Budget = dbudget.ToString();

            ListViewItem Item = new ListViewItem(txtName.Text);
    
            Item.SubItems.Add(txtCost.Text);
            Item.SubItems.Add(Budget);
            lv_spendings.Items.Add(Item);

            txtName.Text = "";
            txtCost.Text = "";
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
                updated = dbudget.ToString();
                lv_spendings.SelectedItems[0].SubItems[2].Text = updated;

                update = true; 
                btnEnter.PerformClick();

            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting selected item. Continue?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lv_spendings.Items.RemoveAt(lv_spendings.SelectedIndices[0]);
                txtName.Text = "";
                txtCost.Text = "";
            }
        }

        private void lv_spendings_MouseClick(object sender, MouseEventArgs e)
        { 
            txtName.Text = lv_spendings.SelectedItems[0].SubItems[0].Text;
            txtCost.Text = lv_spendings.SelectedItems[0].SubItems[1].Text;
        }
    }
}
