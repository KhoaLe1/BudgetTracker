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
                BtnEnter.PerformClick();
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
                TxtName.Enabled = true;
                TxtCost.Enabled = true;
            }


            if (TxtIn.Text != "") { GlobalVariables.Budget = TxtIn.Text; }
            TxtIn.Text = "";

            if (GlobalVariables.Update == false || GlobalVariables.Isempty == true)
            {
                GlobalVariables.Dbudget = double.Parse(GlobalVariables.Budget); // text to double type
                ExpectF.Text = "$" + GlobalVariables.Budget;
                GlobalVariables.BudNum = double.Parse(GlobalVariables.Budget);
            }
            else if ((GlobalVariables.Update == true && TxtIn.Text != "") && GlobalVariables.Isempty == false)
            {
                ExpectF.Text = "$" + GlobalVariables.Updated;
            }

            GlobalVariables.Percentage = Math.Truncate((GlobalVariables.Dbudget / GlobalVariables.BudNum) * 100);

            if (GlobalVariables.Dbudget != 0) { GlobalVariables.In_Percent = Convert.ToInt32(GlobalVariables.Percentage); }
            else { GlobalVariables.In_Percent = 0; }

            VBar1.Value = GlobalVariables.In_Percent;
            Pcent.Text = GlobalVariables.Percentage.ToString() + "%";
        }

        private void EDnP_Click(object sender, EventArgs e)
        {
            if (TxtCost.Text == "") { TxtCost.Text = "0"; }
            GlobalVariables.IsNum = double.TryParse(TxtCost.Text, out double NumOnly);
            if (GlobalVariables.IsNum == true)
            {
                GlobalVariables.Spent = double.Parse(TxtCost.Text);
                GlobalVariables.Dbudget -= GlobalVariables.Spent;

                GlobalVariables.SetBudget = GlobalVariables.Dbudget.ToString();

                ListViewItem Item = new ListViewItem(TxtName.Text);

                Item.SubItems.Add(TxtCost.Text);
                Item.SubItems.Add(GlobalVariables.SetBudget);
                lv_spendings.Items.Add(Item);

                TxtName.Text = "";
                TxtCost.Text = "";
                //budNum = double.Parse(Budget);
                ExpectF.Text = "$" + GlobalVariables.Dbudget;

                GlobalVariables.Percentage = Math.Truncate((GlobalVariables.Dbudget / GlobalVariables.BudNum) * 100);
                GlobalVariables.In_Percent = Convert.ToInt32(GlobalVariables.Percentage);
                VBar1.Value = GlobalVariables.In_Percent;
                Pcent.Text = GlobalVariables.Percentage.ToString() + "%";

                //vBar1.Update();
            }
            else
            {
                MessageBox.Show("Only input numbers for Cost", "Numbers Only Please", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != "")
            {
                lv_spendings.SelectedItems[0].SubItems[0].Text = TxtName.Text;
            }

            if (TxtCost.Text != "")
            {
                GlobalVariables.Spent = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                GlobalVariables.Dbudget += GlobalVariables.Spent;
                // add back previous value
                lv_spendings.SelectedItems[0].SubItems[1].Text = TxtCost.Text;

                GlobalVariables.Spent = double.Parse(lv_spendings.SelectedItems[0].SubItems[1].Text);
                GlobalVariables.Dbudget -= GlobalVariables.Spent;
                //subtract updated value
                GlobalVariables.Updated = GlobalVariables.Dbudget.ToString();
                lv_spendings.SelectedItems[0].SubItems[2].Text = GlobalVariables.Updated;

                GlobalVariables.Update = true;
                BtnEnter.PerformClick();

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

                BtnEnter.PerformClick();

                TxtName.Text = "";
                TxtCost.Text = "";

            }
        }

        private void Lv_spendings_MouseClick(object sender, MouseEventArgs e)
        {
            if (lv_spendings.SelectedItems.Count != 0)
            {
                TxtName.Text = lv_spendings.SelectedItems[0].SubItems[0].Text;
                TxtCost.Text = lv_spendings.SelectedItems[0].SubItems[1].Text;
            }
        }
    }
}
