using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class MthlySpending : UserControl
    {
        public MthlySpending()
        {
            InitializeComponent();
        }



        //-------Not Used----------//
        private void pcent_Click(object sender, EventArgs e)
        {

        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void vBar1_Click(object sender, EventArgs e)
        {

        }

        private void lv_spendings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------//




        private void clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning: This will clear all inputed data. Do you want to continue?", "CLEAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lv_spendings.Items.Clear();
                GlobalVariables.updated = "0";
                GlobalVariables.Budget = "0";
                GlobalVariables.iPercent = 0;
                GlobalVariables.update = false;
                btnEnter.PerformClick();
            }
        }

        private void txtIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar));
            if (e.Handled == true)
            {
                MessageBox.Show("Only input numbers for your Budget", "Numbers Only Please", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

       
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.update == false)
            {
                txtName.Enabled = true;
                txtCost.Enabled = true;
            }


            if (txtIn.Text != "") { GlobalVariables.Budget = txtIn.Text; }
            txtIn.Text = "";

            if (GlobalVariables.update == false || GlobalVariables.isempty == true)
            {
                GlobalVariables.dbudget = double.Parse(GlobalVariables.Budget); // text to double type
                expectF.Text = "$" + GlobalVariables.Budget;
                GlobalVariables.budNum = double.Parse(GlobalVariables.Budget);
            }
            else if ((GlobalVariables.update == true && txtIn.Text != "") && GlobalVariables.isempty == false)
            {
                expectF.Text = "$" + GlobalVariables.updated;
            }

            GlobalVariables.percentage = Math.Truncate((GlobalVariables.dbudget / GlobalVariables.budNum) * 100);

            if (GlobalVariables.dbudget != 0) { GlobalVariables.iPercent = Convert.ToInt32(GlobalVariables.percentage); }
            else { GlobalVariables.iPercent = 0; }

            vBar1.Value = GlobalVariables.iPercent;
            pcent.Text = GlobalVariables.percentage.ToString() + "%";
        }

        private void eDnP_Click(object sender, EventArgs e)
        {
            if (txtCost.Text == "") { txtCost.Text = "0"; }
            GlobalVariables.isNum = double.TryParse(txtCost.Text, out double numOnly);
            if (GlobalVariables.isNum == true)
            {
                GlobalVariables.spent = double.Parse(txtCost.Text);
                GlobalVariables.dbudget = GlobalVariables.dbudget - GlobalVariables.spent;

                GlobalVariables.setBudget = GlobalVariables.dbudget.ToString();

                ListViewItem Item = new ListViewItem(txtName.Text);

                Item.SubItems.Add(txtCost.Text);
                Item.SubItems.Add(GlobalVariables.setBudget);
                lv_spendings.Items.Add(Item);

                txtName.Text = "";
                txtCost.Text = "";
                //budNum = double.Parse(Budget);
                expectF.Text = "$" + GlobalVariables.dbudget;

                GlobalVariables.percentage = Math.Truncate((GlobalVariables.dbudget / GlobalVariables.budNum) * 100);
                GlobalVariables.iPercent = Convert.ToInt32(GlobalVariables.percentage);
                vBar1.Value = GlobalVariables.iPercent;
                pcent.Text = GlobalVariables.percentage.ToString() + "%";

                //vBar1.Update();
            }
            else
            {
                MessageBox.Show("Only input numbers for Cost", "Numbers Only Please", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                lv_spendings.SelectedItems[0].SubItems[0].Text = txtName.Text;
            }

            if (txtCost.Text != "")
            {
                GlobalVariables.spent = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                GlobalVariables.dbudget = GlobalVariables.dbudget + GlobalVariables.spent;
                // add back previous value
                lv_spendings.SelectedItems[0].SubItems[1].Text = txtCost.Text;

                GlobalVariables.spent = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                GlobalVariables.dbudget = GlobalVariables.dbudget - GlobalVariables.spent;
                //subtract updated value
                GlobalVariables.updated = GlobalVariables.dbudget.ToString();
                lv_spendings.SelectedItems[0].SubItems[2].Text = GlobalVariables.updated;

                GlobalVariables.update = true;
                btnEnter.PerformClick();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting selected item. Continue?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                GlobalVariables.addBack = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                GlobalVariables.dbudget += GlobalVariables.addBack;
                GlobalVariables.updated = GlobalVariables.dbudget.ToString();

                lv_spendings.Items.RemoveAt(lv_spendings.SelectedIndices[0]);
                GlobalVariables.update = true;

                //string ls = lv_spendings.Items.Count.ToString();
                //MessageBox.Show(ls,"Size",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (lv_spendings.Items.Count == 0) { GlobalVariables.isempty = true; }

                btnEnter.PerformClick();

                txtName.Text = "";
                txtCost.Text = "";

            }
        }

        private void lv_spendings_MouseClick(object sender, MouseEventArgs e)
        {
            if (lv_spendings.SelectedItems.Count != 0)
            {
                txtName.Text = lv_spendings.SelectedItems[0].SubItems[0].Text;
                txtCost.Text = lv_spendings.SelectedItems[0].SubItems[1].Text;
            }
        }
    }
}
