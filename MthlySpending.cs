using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class MthlySpending : UserControl
    {
        public MthlySpending()
        {
            InitializeComponent();
        }



        //-------Not Used----------//
        private void Pcent_Click(object sender, EventArgs e)
        {

        }

        private void TxtIn_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void VBar1_Click(object sender, EventArgs e)
        {

        }

        private void Lv_spendings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------//




        private void Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning: This will clear all inputed data. Do you want to continue?", "CLEAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lv_spendings.Items.Clear();
                GlobalVariables.Updated = "0";
                GlobalVariables.Budget = "0";
                GlobalVariables.In_Percent = 0;
                GlobalVariables.Update = false;
                btnEnter.PerformClick();
            }
        }

        private void TxtIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar));
            if (e.Handled == true)
            {
                MessageBox.Show("Only input numbers for your Budget", "Numbers Only Please", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

       
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Update == false)
            {
                txtName.Enabled = true;
                txtCost.Enabled = true;
            }


            if (txtIn.Text != "") { GlobalVariables.Budget = txtIn.Text; }
            txtIn.Text = "";

            if (GlobalVariables.Update == false || GlobalVariables.Isempty == true)
            {
                GlobalVariables.Dbudget = double.Parse(GlobalVariables.Budget); // text to double type
                expectF.Text = "$" + GlobalVariables.Budget;
                GlobalVariables.BudNum = double.Parse(GlobalVariables.Budget);
            }
            else if ((GlobalVariables.Update == true && txtIn.Text != "") && GlobalVariables.Isempty == false)
            {
                expectF.Text = "$" + GlobalVariables.Updated;
            }

            GlobalVariables.Percentage = Math.Truncate((GlobalVariables.Dbudget / GlobalVariables.BudNum) * 100);

            if (GlobalVariables.Dbudget != 0) { GlobalVariables.In_Percent = Convert.ToInt32(GlobalVariables.Percentage); }
            else { GlobalVariables.In_Percent = 0; }

            vBar1.Value = GlobalVariables.In_Percent;
            pcent.Text = GlobalVariables.Percentage.ToString() + "%";
        }

        private void EDnP_Click(object sender, EventArgs e)
        {
            if (txtCost.Text == "") { txtCost.Text = "0"; }
            GlobalVariables.IsNum = double.TryParse(txtCost.Text, out double NumOnly);
            if (GlobalVariables.IsNum == true)
            {
                GlobalVariables.Spent = double.Parse(txtCost.Text);
                GlobalVariables.Dbudget -= GlobalVariables.Spent;

                GlobalVariables.SetBudget = GlobalVariables.Dbudget.ToString();

                ListViewItem Item = new ListViewItem(txtName.Text);

                Item.SubItems.Add(txtCost.Text);
                Item.SubItems.Add(GlobalVariables.SetBudget);
                lv_spendings.Items.Add(Item);

                txtName.Text = "";
                txtCost.Text = "";
                //budNum = double.Parse(Budget);
                expectF.Text = "$" + GlobalVariables.Dbudget;

                GlobalVariables.Percentage = Math.Truncate((GlobalVariables.Dbudget / GlobalVariables.BudNum) * 100);
                GlobalVariables.In_Percent = Convert.ToInt32(GlobalVariables.Percentage);
                vBar1.Value = GlobalVariables.In_Percent;
                pcent.Text = GlobalVariables.Percentage.ToString() + "%";

                //vBar1.Update();
            }
            else
            {
                MessageBox.Show("Only input numbers for Cost", "Numbers Only Please", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                lv_spendings.SelectedItems[0].SubItems[0].Text = txtName.Text;
            }

            if (txtCost.Text != "")
            {
                GlobalVariables.Spent = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                GlobalVariables.Dbudget += GlobalVariables.Spent;
                // add back previous value
                lv_spendings.SelectedItems[0].SubItems[1].Text = txtCost.Text;

                GlobalVariables.Spent = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                GlobalVariables.Dbudget -= GlobalVariables.Spent;
                //subtract updated value
                GlobalVariables.Updated = GlobalVariables.Dbudget.ToString();
                lv_spendings.SelectedItems[0].SubItems[2].Text = GlobalVariables.Updated;

                GlobalVariables.Update = true;
                btnEnter.PerformClick();

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting selected item. Continue?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                GlobalVariables.AddBack = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                GlobalVariables.Dbudget += GlobalVariables.AddBack;
                GlobalVariables.Updated = GlobalVariables.Dbudget.ToString();

                lv_spendings.Items.RemoveAt(lv_spendings.SelectedIndices[0]);
                GlobalVariables.Update = true;

                //string ls = lv_spendings.Items.Count.ToString();
                //MessageBox.Show(ls,"Size",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (lv_spendings.Items.Count == 0) { GlobalVariables.Isempty = true; }

                btnEnter.PerformClick();

                txtName.Text = "";
                txtCost.Text = "";

            }
        }

        private void Lv_spendings_MouseClick(object sender, MouseEventArgs e)
        {
            if (lv_spendings.SelectedItems.Count != 0)
            {
                txtName.Text = lv_spendings.SelectedItems[0].SubItems[0].Text;
                txtCost.Text = lv_spendings.SelectedItems[0].SubItems[1].Text;
            }
        }
    }
}
