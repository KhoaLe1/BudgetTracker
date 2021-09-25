
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
            this.label1 = new System.Windows.Forms.Label();
            this.lv_spendings = new System.Windows.Forms.ListView();
            this.ch_description = new System.Windows.Forms.ColumnHeader();
            this.ch_cost = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Spendings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lv_spendings
            // 
            this.lv_spendings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_description,
            this.ch_cost});
            this.lv_spendings.HideSelection = false;
            this.lv_spendings.Location = new System.Drawing.Point(12, 26);
            this.lv_spendings.Name = "lv_spendings";
            this.lv_spendings.Size = new System.Drawing.Size(161, 400);
            this.lv_spendings.TabIndex = 1;
            this.lv_spendings.UseCompatibleStateImageBehavior = false;
            this.lv_spendings.View = System.Windows.Forms.View.Details;
            this.lv_spendings.SelectedIndexChanged += new System.EventHandler(this.lv_spendings_SelectedIndexChanged);
            // 
            // ch_description
            // 
            this.ch_description.Text = "Description";
            this.ch_description.Width = 100;
            // 
            // ch_cost
            // 
            this.ch_cost.Text = "Cost";
            this.ch_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toMoSpending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.lv_spendings);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "toMoSpending";
            this.Text = "toMoSpending";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_spendings;
        private System.Windows.Forms.ColumnHeader ch_description;
        private System.Windows.Forms.ColumnHeader ch_cost;
    }
}