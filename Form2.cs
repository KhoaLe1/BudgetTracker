using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FinanceTracker
{
    public partial class Form2 : Form
    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        

        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel2.Height = BtnDashboard.Height;
            panel2.Top = BtnDashboard.Top;
            panel2.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(128, 255, 255);

            lbTitle.Text = "DashBoard";
            this.PnlFormLoader.Controls.Clear();
            toDashboard FrmDashboard_Vrb = new toDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            panel2.Height = BtnDashboard.Height;
            panel2.Top = BtnDashboard.Top;
            panel2.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(128, 255, 255);

            lbTitle.Text = "DashBoard";
            this.PnlFormLoader.Controls.Clear();
            toDashboard FrmDashboard_Vrb = new toDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private void BtnMonth_Click(object sender, EventArgs e)
        {
            panel2.Height = BtnMonth.Height;
            panel2.Top = BtnMonth.Top;
            panel2.Left = BtnMonth.Left;
            BtnMonth.BackColor = Color.FromArgb(128, 255, 255);

            lbTitle.Text = "Monthly Spending";
            this.PnlFormLoader.Controls.Clear();
            toMoSpending FrmDashboard_Vrb = new toMoSpending() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private void BtnSavings_Click(object sender, EventArgs e)
        {
           panel2.Height = BtnSavings.Height;
            panel2.Top = BtnSavings.Top;
            panel2.Left = BtnSavings.Left;
            BtnSavings.BackColor = Color.FromArgb(128, 255, 255);

            lbTitle.Text = "Savings";
            this.PnlFormLoader.Controls.Clear();
            toSavings FrmDashboard_Vrb = new toSavings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private void BtnBreakdown_Click(object sender, EventArgs e)
        {
            panel2.Height = BtnBreakdown.Height;
            panel2.Top = BtnBreakdown.Top;
            panel2.Left = BtnBreakdown.Left;
            BtnBreakdown.BackColor = Color.FromArgb(128, 255, 255);

            lbTitle.Text = "Visual Breakdown";
            this.PnlFormLoader.Controls.Clear();
            toBreakdown FrmDashboard_Vrb = new toBreakdown() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(128, 255, 255);
        }

        private void BtnMonth_Leave(object sender, EventArgs e)
        {
            BtnMonth.BackColor = Color.FromArgb(128, 255, 255);
        }

        private void BtnSavings_Leave(object sender, EventArgs e)
        {
            BtnSavings.BackColor = Color.FromArgb(128, 255, 255);
        }

        private void BtnBreakdown_Leave(object sender, EventArgs e)
        {
            BtnBreakdown.BackColor = Color.FromArgb(128, 255, 255);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            panel2.Height = Settings.Height;
            panel2.Top = Settings.Top;
            panel2.Left = Settings.Left;
            Settings.BackColor = Color.FromArgb(128, 255, 255); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void vBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
