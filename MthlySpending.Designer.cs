
namespace FinanceTracker
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pcent = new System.Windows.Forms.Label();
            this.expectF = new System.Windows.Forms.Label();
            this.aFunds = new System.Windows.Forms.Label();
            this.vBar1 = new FinanceTracker.vBar();
            this.newMnth = new System.Windows.Forms.Button();
            this.eDnP = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.ePrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.eDescrib = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.exIncome = new System.Windows.Forms.Label();
            this.lv_spendings = new System.Windows.Forms.ListView();
            this.ch_description = new System.Windows.Forms.ColumnHeader();
            this.ch_cost = new System.Windows.Forms.ColumnHeader();
            this.ch_budget = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(514, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 23);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(639, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEnter.Location = new System.Drawing.Point(310, 132);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(65, 23);
            this.btnEnter.TabIndex = 33;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // pcent
            // 
            this.pcent.Location = new System.Drawing.Point(113, 427);
            this.pcent.Name = "pcent";
            this.pcent.Size = new System.Drawing.Size(50, 23);
            this.pcent.TabIndex = 32;
            this.pcent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pcent.Click += new System.EventHandler(this.pcent_Click);
            // 
            // expectF
            // 
            this.expectF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expectF.ForeColor = System.Drawing.Color.Aqua;
            this.expectF.Location = new System.Drawing.Point(69, 91);
            this.expectF.Name = "expectF";
            this.expectF.Size = new System.Drawing.Size(137, 23);
            this.expectF.TabIndex = 31;
            this.expectF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aFunds
            // 
            this.aFunds.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aFunds.ForeColor = System.Drawing.Color.Cyan;
            this.aFunds.Location = new System.Drawing.Point(69, 51);
            this.aFunds.Name = "aFunds";
            this.aFunds.Size = new System.Drawing.Size(137, 31);
            this.aFunds.TabIndex = 30;
            this.aFunds.Text = "Remaining Budget";
            this.aFunds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vBar1
            // 
            this.vBar1.Location = new System.Drawing.Point(113, 132);
            this.vBar1.Name = "vBar1";
            this.vBar1.Size = new System.Drawing.Size(50, 289);
            this.vBar1.TabIndex = 29;
            this.vBar1.Click += new System.EventHandler(this.vBar1_Click);
            // 
            // newMnth
            // 
            this.newMnth.Location = new System.Drawing.Point(298, 184);
            this.newMnth.Name = "newMnth";
            this.newMnth.Size = new System.Drawing.Size(91, 23);
            this.newMnth.TabIndex = 28;
            this.newMnth.Text = "New Month";
            this.newMnth.UseVisualStyleBackColor = true;
            this.newMnth.Click += new System.EventHandler(this.clear_Click);
            // 
            // eDnP
            // 
            this.eDnP.Location = new System.Drawing.Point(575, 132);
            this.eDnP.Name = "eDnP";
            this.eDnP.Size = new System.Drawing.Size(69, 23);
            this.eDnP.TabIndex = 27;
            this.eDnP.Text = "Add";
            this.eDnP.UseVisualStyleBackColor = true;
            this.eDnP.Click += new System.EventHandler(this.eDnP_Click);
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(589, 89);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(119, 23);
            this.txtCost.TabIndex = 26;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // ePrice
            // 
            this.ePrice.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ePrice.ForeColor = System.Drawing.Color.Aqua;
            this.ePrice.Location = new System.Drawing.Point(464, 89);
            this.ePrice.Name = "ePrice";
            this.ePrice.Size = new System.Drawing.Size(119, 23);
            this.ePrice.TabIndex = 25;
            this.ePrice.Text = "Cost";
            this.ePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(589, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 23);
            this.txtName.TabIndex = 24;
            // 
            // eDescrib
            // 
            this.eDescrib.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eDescrib.ForeColor = System.Drawing.Color.Aqua;
            this.eDescrib.Location = new System.Drawing.Point(464, 55);
            this.eDescrib.Name = "eDescrib";
            this.eDescrib.Size = new System.Drawing.Size(119, 23);
            this.eDescrib.TabIndex = 23;
            this.eDescrib.Text = "Description";
            this.eDescrib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(283, 91);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(119, 23);
            this.txtIn.TabIndex = 22;
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            this.txtIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIn_KeyPress);
            // 
            // exIncome
            // 
            this.exIncome.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exIncome.ForeColor = System.Drawing.Color.Aqua;
            this.exIncome.Location = new System.Drawing.Point(274, 55);
            this.exIncome.Name = "exIncome";
            this.exIncome.Size = new System.Drawing.Size(139, 23);
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
            this.lv_spendings.Location = new System.Drawing.Point(274, 230);
            this.lv_spendings.Name = "lv_spendings";
            this.lv_spendings.Size = new System.Drawing.Size(443, 220);
            this.lv_spendings.TabIndex = 20;
            this.lv_spendings.UseCompatibleStateImageBehavior = false;
            this.lv_spendings.View = System.Windows.Forms.View.Details;
            this.lv_spendings.SelectedIndexChanged += new System.EventHandler(this.lv_spendings_SelectedIndexChanged);
            this.lv_spendings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_spendings_MouseClick);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.pcent);
            this.Controls.Add(this.expectF);
            this.Controls.Add(this.aFunds);
            this.Controls.Add(this.vBar1);
            this.Controls.Add(this.newMnth);
            this.Controls.Add(this.eDnP);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.ePrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.eDescrib);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.exIncome);
            this.Controls.Add(this.lv_spendings);
            this.Name = "MthlySpending";
            this.Size = new System.Drawing.Size(784, 495);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label pcent;
        private System.Windows.Forms.Label expectF;
        private System.Windows.Forms.Label aFunds;
        private vBar vBar1;
        private System.Windows.Forms.Button newMnth;
        private System.Windows.Forms.Button eDnP;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label ePrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label eDescrib;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label exIncome;
        private System.Windows.Forms.ListView lv_spendings;
        private System.Windows.Forms.ColumnHeader ch_description;
        private System.Windows.Forms.ColumnHeader ch_cost;
        private System.Windows.Forms.ColumnHeader ch_budget;
    }
}
