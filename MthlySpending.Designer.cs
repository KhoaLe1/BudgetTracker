
namespace BudgetTracker
{
    partial class MthlySpending
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.Pcent = new System.Windows.Forms.Label();
            this.ExpectF = new System.Windows.Forms.Label();
            this.AFunds = new System.Windows.Forms.Label();
            this.VBar1 = new BudgetTracker.VBar();
            this.NewMnth = new System.Windows.Forms.Button();
            this.EDnP = new System.Windows.Forms.Button();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.ePrice = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.eDescrib = new System.Windows.Forms.Label();
            this.TxtIn = new System.Windows.Forms.TextBox();
            this.exIncome = new System.Windows.Forms.Label();
            this.lv_spendings = new System.Windows.Forms.ListView();
            this.ch_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(441, 159);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(59, 20);
            this.BtnUpdate.TabIndex = 35;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(548, 159);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(59, 20);
            this.BtnDelete.TabIndex = 34;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.SystemColors.Menu;
            this.BtnEnter.Location = new System.Drawing.Point(266, 114);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(56, 20);
            this.BtnEnter.TabIndex = 33;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // Pcent
            // 
            this.Pcent.Location = new System.Drawing.Point(97, 370);
            this.Pcent.Name = "Pcent";
            this.Pcent.Size = new System.Drawing.Size(43, 20);
            this.Pcent.TabIndex = 32;
            this.Pcent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pcent.Click += new System.EventHandler(this.Pcent_Click);
            // 
            // ExpectF
            // 
            this.ExpectF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ExpectF.ForeColor = System.Drawing.Color.Aqua;
            this.ExpectF.Location = new System.Drawing.Point(59, 79);
            this.ExpectF.Name = "ExpectF";
            this.ExpectF.Size = new System.Drawing.Size(117, 20);
            this.ExpectF.TabIndex = 31;
            this.ExpectF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AFunds
            // 
            this.AFunds.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.AFunds.ForeColor = System.Drawing.Color.Cyan;
            this.AFunds.Location = new System.Drawing.Point(59, 44);
            this.AFunds.Name = "AFunds";
            this.AFunds.Size = new System.Drawing.Size(117, 27);
            this.AFunds.TabIndex = 30;
            this.AFunds.Text = "Remaining Budget";
            this.AFunds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VBar1
            // 
            this.VBar1.Location = new System.Drawing.Point(97, 114);
            this.VBar1.Name = "VBar1";
            this.VBar1.Size = new System.Drawing.Size(43, 250);
            this.VBar1.TabIndex = 29;
            this.VBar1.Click += new System.EventHandler(this.VBar1_Click);
            // 
            // NewMnth
            // 
            this.NewMnth.Location = new System.Drawing.Point(255, 159);
            this.NewMnth.Name = "NewMnth";
            this.NewMnth.Size = new System.Drawing.Size(78, 20);
            this.NewMnth.TabIndex = 28;
            this.NewMnth.Text = "New Month";
            this.NewMnth.UseVisualStyleBackColor = true;
            this.NewMnth.Click += new System.EventHandler(this.Clear_Click);
            // 
            // EDnP
            // 
            this.EDnP.Location = new System.Drawing.Point(505, 114);
            this.EDnP.Name = "EDnP";
            this.EDnP.Size = new System.Drawing.Size(59, 20);
            this.EDnP.TabIndex = 27;
            this.EDnP.Text = "Add";
            this.EDnP.UseVisualStyleBackColor = true;
            this.EDnP.Click += new System.EventHandler(this.EDnP_Click);
            // 
            // TxtCost
            // 
            this.TxtCost.Enabled = false;
            this.TxtCost.Location = new System.Drawing.Point(505, 77);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(103, 20);
            this.TxtCost.TabIndex = 26;
            this.TxtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // ePrice
            // 
            this.ePrice.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.ePrice.ForeColor = System.Drawing.Color.Aqua;
            this.ePrice.Location = new System.Drawing.Point(398, 77);
            this.ePrice.Name = "ePrice";
            this.ePrice.Size = new System.Drawing.Size(102, 20);
            this.ePrice.TabIndex = 25;
            this.ePrice.Text = "Cost";
            this.ePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(505, 49);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(103, 20);
            this.TxtName.TabIndex = 24;
            // 
            // eDescrib
            // 
            this.eDescrib.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.eDescrib.ForeColor = System.Drawing.Color.Aqua;
            this.eDescrib.Location = new System.Drawing.Point(398, 48);
            this.eDescrib.Name = "eDescrib";
            this.eDescrib.Size = new System.Drawing.Size(102, 20);
            this.eDescrib.TabIndex = 23;
            this.eDescrib.Text = "Description";
            this.eDescrib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtIn
            // 
            this.TxtIn.Location = new System.Drawing.Point(243, 79);
            this.TxtIn.Name = "TxtIn";
            this.TxtIn.Size = new System.Drawing.Size(103, 20);
            this.TxtIn.TabIndex = 22;
            this.TxtIn.TextChanged += new System.EventHandler(this.TxtIn_TextChanged);
            this.TxtIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIn_KeyPress);
            // 
            // exIncome
            // 
            this.exIncome.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.exIncome.ForeColor = System.Drawing.Color.Aqua;
            this.exIncome.Location = new System.Drawing.Point(235, 48);
            this.exIncome.Name = "exIncome";
            this.exIncome.Size = new System.Drawing.Size(119, 20);
            this.exIncome.TabIndex = 21;
            this.exIncome.Text = "Expected Budget";
            this.exIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lv_spendings
            // 
            this.lv_spendings.BackColor = System.Drawing.Color.White;
            this.lv_spendings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_description,
            this.ch_cost,
            this.ch_budget});
            this.lv_spendings.HideSelection = false;
            this.lv_spendings.Location = new System.Drawing.Point(235, 199);
            this.lv_spendings.Name = "lv_spendings";
            this.lv_spendings.Size = new System.Drawing.Size(380, 191);
            this.lv_spendings.TabIndex = 20;
            this.lv_spendings.UseCompatibleStateImageBehavior = false;
            this.lv_spendings.View = System.Windows.Forms.View.Details;
            this.lv_spendings.SelectedIndexChanged += new System.EventHandler(this.Lv_spendings_SelectedIndexChanged);
            this.lv_spendings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lv_spendings_MouseClick);
            // 
            // ch_description
            // 
            this.ch_description.Text = "Description";
            this.ch_description.Width = 250;
            // 
            // ch_cost
            // 
            this.ch_cost.Text = "Cost";
            this.ch_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_cost.Width = 100;
            // 
            // ch_budget
            // 
            this.ch_budget.Text = "Budget";
            this.ch_budget.Width = 100;
            // 
            // MthlySpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.Pcent);
            this.Controls.Add(this.ExpectF);
            this.Controls.Add(this.AFunds);
            this.Controls.Add(this.VBar1);
            this.Controls.Add(this.NewMnth);
            this.Controls.Add(this.EDnP);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.ePrice);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.eDescrib);
            this.Controls.Add(this.TxtIn);
            this.Controls.Add(this.exIncome);
            this.Controls.Add(this.lv_spendings);
            this.Name = "MthlySpending";
            this.Size = new System.Drawing.Size(672, 429);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label Pcent;
        private System.Windows.Forms.Label ExpectF;
        private System.Windows.Forms.Label AFunds;
        private VBar VBar1;
        private System.Windows.Forms.Button NewMnth;
        private System.Windows.Forms.Button EDnP;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label ePrice;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label eDescrib;
        private System.Windows.Forms.TextBox TxtIn;
        private System.Windows.Forms.Label exIncome;
        private System.Windows.Forms.ListView lv_spendings;
        private System.Windows.Forms.ColumnHeader ch_description;
        private System.Windows.Forms.ColumnHeader ch_cost;
        private System.Windows.Forms.ColumnHeader ch_budget;
    }
}
