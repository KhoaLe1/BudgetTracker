
namespace FinanceTracker
{
    partial class toMoSpending
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_spendings = new System.Windows.Forms.ListView();
            this.ch_description = new System.Windows.Forms.ColumnHeader();
            this.ch_cost = new System.Windows.Forms.ColumnHeader();
            this.ch_budget = new System.Windows.Forms.ColumnHeader();
            this.exIncome = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.eDescrib = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ePrice = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.eDnP = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.vBar1 = new FinanceTracker.vBar();
            this.aFunds = new System.Windows.Forms.Label();
            this.expectF = new System.Windows.Forms.Label();
            this.pcent = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_spendings
            // 
            this.lv_spendings.BackColor = System.Drawing.Color.White;
            this.lv_spendings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_description,
            this.ch_cost,
            this.ch_budget});
            this.lv_spendings.HideSelection = false;
            this.lv_spendings.Location = new System.Drawing.Point(240, 188);
            this.lv_spendings.Name = "lv_spendings";
            this.lv_spendings.Size = new System.Drawing.Size(443, 220);
            this.lv_spendings.TabIndex = 1;
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
            // exIncome
            // 
            this.exIncome.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exIncome.Location = new System.Drawing.Point(240, 13);
            this.exIncome.Name = "exIncome";
            this.exIncome.Size = new System.Drawing.Size(139, 23);
            this.exIncome.TabIndex = 2;
            this.exIncome.Text = "Expected Budget";
            this.exIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(249, 49);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(119, 23);
            this.txtIn.TabIndex = 3;
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            // 
            // eDescrib
            // 
            this.eDescrib.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eDescrib.Location = new System.Drawing.Point(430, 13);
            this.eDescrib.Name = "eDescrib";
            this.eDescrib.Size = new System.Drawing.Size(119, 23);
            this.eDescrib.TabIndex = 4;
            this.eDescrib.Text = "Description";
            this.eDescrib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(555, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 23);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ePrice
            // 
            this.ePrice.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ePrice.Location = new System.Drawing.Point(430, 47);
            this.ePrice.Name = "ePrice";
            this.ePrice.Size = new System.Drawing.Size(119, 23);
            this.ePrice.TabIndex = 6;
            this.ePrice.Text = "Cost";
            this.ePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(555, 47);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(119, 23);
            this.txtCost.TabIndex = 8;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // eDnP
            // 
            this.eDnP.Location = new System.Drawing.Point(599, 90);
            this.eDnP.Name = "eDnP";
            this.eDnP.Size = new System.Drawing.Size(75, 23);
            this.eDnP.TabIndex = 10;
            this.eDnP.Text = "Add";
            this.eDnP.UseVisualStyleBackColor = true;
            this.eDnP.Click += new System.EventHandler(this.eDnP_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(474, 90);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear All";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // vBar1
            // 
            this.vBar1.Location = new System.Drawing.Point(69, 90);
            this.vBar1.Name = "vBar1";
            this.vBar1.Size = new System.Drawing.Size(50, 289);
            this.vBar1.TabIndex = 12;
            this.vBar1.Click += new System.EventHandler(this.vBar1_Click);
            // 
            // aFunds
            // 
            this.aFunds.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aFunds.Location = new System.Drawing.Point(35, 9);
            this.aFunds.Name = "aFunds";
            this.aFunds.Size = new System.Drawing.Size(137, 31);
            this.aFunds.TabIndex = 13;
            this.aFunds.Text = "Remaining Budget";
            this.aFunds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expectF
            // 
            this.expectF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expectF.Location = new System.Drawing.Point(35, 40);
            this.expectF.Name = "expectF";
            this.expectF.Size = new System.Drawing.Size(137, 23);
            this.expectF.TabIndex = 14;
            this.expectF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.expectF.Click += new System.EventHandler(this.txtIn_TextChanged);
            // 
            // pcent
            // 
            this.pcent.Location = new System.Drawing.Point(69, 385);
            this.pcent.Name = "pcent";
            this.pcent.Size = new System.Drawing.Size(50, 23);
            this.pcent.TabIndex = 15;
            this.pcent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(276, 90);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(65, 23);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.eIn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(599, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(474, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // toMoSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.pcent);
            this.Controls.Add(this.expectF);
            this.Controls.Add(this.aFunds);
            this.Controls.Add(this.vBar1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.eDnP);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.ePrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.eDescrib);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.exIncome);
            this.Controls.Add(this.lv_spendings);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "toMoSpending";
            this.Text = "toMoSpending";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lv_spendings;
        private System.Windows.Forms.ColumnHeader ch_description;
        private System.Windows.Forms.ColumnHeader ch_cost;
        private System.Windows.Forms.ColumnHeader ch_budget;
        private System.Windows.Forms.Label exIncome;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label eDescrib;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label ePrice;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button eDnP;
        private System.Windows.Forms.Button clear;
        private vBar vBar1;
        private System.Windows.Forms.Label aFunds;
        private System.Windows.Forms.Label expectF;
        private System.Windows.Forms.Label pcent;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}