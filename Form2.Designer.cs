
namespace BudgetTracker 
{ 
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sad = new System.Windows.Forms.Label();
            this.usrname = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.MnthlySpending = new BudgetTracker.MthlySpending();
            this.Dashboard = new BudgetTracker.Dashboard();
            this.button1 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.BtnBreakdown = new System.Windows.Forms.Button();
            this.BtnSavings = new System.Windows.Forms.Button();
            this.BtnMonth = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlFormLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Controls.Add(this.BtnBreakdown);
            this.panel1.Controls.Add(this.BtnSavings);
            this.panel1.Controls.Add(this.BtnMonth);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 500);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.sad);
            this.panel2.Controls.Add(this.usrname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 89);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // sad
            // 
            this.sad.BackColor = System.Drawing.SystemColors.Menu;
            this.sad.ForeColor = System.Drawing.Color.Black;
            this.sad.Location = new System.Drawing.Point(33, 76);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(81, 13);
            this.sad.TabIndex = 2;
            this.sad.Text = "Last Signed In:";
            this.sad.Click += new System.EventHandler(this.Label2_Click);
            // 
            // usrname
            // 
            this.usrname.AutoSize = true;
            this.usrname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.usrname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.usrname.Location = new System.Drawing.Point(33, 57);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(94, 21);
            this.usrname.TabIndex = 1;
            this.usrname.Text = "User Name";
            this.usrname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usrname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Showcard Gothic", 21F);
            this.lbTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTitle.Location = new System.Drawing.Point(148, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(185, 35);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Dashboard";
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Controls.Add(this.MnthlySpending);
            this.PnlFormLoader.Controls.Add(this.Dashboard);
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(143, 68);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(672, 432);
            this.PnlFormLoader.TabIndex = 3;
            // 
            // MnthlySpending
            // 
            this.MnthlySpending.BackColor = System.Drawing.Color.MidnightBlue;
            this.MnthlySpending.Location = new System.Drawing.Point(0, 0);
            this.MnthlySpending.Name = "MnthlySpending";
            this.MnthlySpending.Size = new System.Drawing.Size(672, 432);
            this.MnthlySpending.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.AliceBlue;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(672, 432);
            this.Dashboard.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(777, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 29);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings.Location = new System.Drawing.Point(0, 441);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(143, 59);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // BtnBreakdown
            // 
            this.BtnBreakdown.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnBreakdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBreakdown.FlatAppearance.BorderSize = 0;
            this.BtnBreakdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBreakdown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnBreakdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnBreakdown.Image = global::BudgetTracker.Properties.Resources.icons8_pie_chart_30;
            this.BtnBreakdown.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBreakdown.Location = new System.Drawing.Point(0, 266);
            this.BtnBreakdown.Name = "BtnBreakdown";
            this.BtnBreakdown.Size = new System.Drawing.Size(143, 59);
            this.BtnBreakdown.TabIndex = 1;
            this.BtnBreakdown.Text = "Visual Breakdown";
            this.BtnBreakdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBreakdown.UseVisualStyleBackColor = false;
            this.BtnBreakdown.Click += new System.EventHandler(this.BtnBreakdown_Click);
            this.BtnBreakdown.Leave += new System.EventHandler(this.BtnBreakdown_Leave);
            // 
            // BtnSavings
            // 
            this.BtnSavings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnSavings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSavings.FlatAppearance.BorderSize = 0;
            this.BtnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSavings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSavings.Image = global::BudgetTracker.Properties.Resources.icons8_bank_safe_24;
            this.BtnSavings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSavings.Location = new System.Drawing.Point(0, 207);
            this.BtnSavings.Name = "BtnSavings";
            this.BtnSavings.Size = new System.Drawing.Size(143, 59);
            this.BtnSavings.TabIndex = 1;
            this.BtnSavings.Text = "Savings";
            this.BtnSavings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSavings.UseVisualStyleBackColor = false;
            this.BtnSavings.Click += new System.EventHandler(this.BtnSavings_Click);
            this.BtnSavings.Leave += new System.EventHandler(this.BtnSavings_Leave);
            // 
            // BtnMonth
            // 
            this.BtnMonth.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMonth.FlatAppearance.BorderSize = 0;
            this.BtnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnMonth.Image = global::BudgetTracker.Properties.Resources.icons8_calendar_24;
            this.BtnMonth.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMonth.Location = new System.Drawing.Point(0, 148);
            this.BtnMonth.Name = "BtnMonth";
            this.BtnMonth.Size = new System.Drawing.Size(143, 59);
            this.BtnMonth.TabIndex = 1;
            this.BtnMonth.Text = "Monthly Spending";
            this.BtnMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnMonth.UseVisualStyleBackColor = false;
            this.BtnMonth.Click += new System.EventHandler(this.BtnMonth_Click);
            this.BtnMonth.Leave += new System.EventHandler(this.BtnMonth_Leave);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnDashboard.Image = global::BudgetTracker.Properties.Resources.icons8_home_24;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 89);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(143, 59);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.BtnDashboard.Leave += new System.EventHandler(this.BtnDashboard_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BudgetTracker.Properties.Resources.EMqvr1SWkAYMa1M;
            this.pictureBox1.Location = new System.Drawing.Point(45, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(815, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_even);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlFormLoader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usrname;
        private System.Windows.Forms.Label sad;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnMonth;
        private System.Windows.Forms.Button BtnSavings;
        private System.Windows.Forms.Button BtnBreakdown;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Button button1;
        private Dashboard Dashboard;
        private MthlySpending MnthlySpending;
    }
}

