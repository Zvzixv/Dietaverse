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
using Dietaverse.View;

namespace Dietaverse
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint ="CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidrhElipse, int nHeightEllipse);
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = dashboardButton.Height;
            PnlNav.Top = dashboardButton.Top;
            PnlNav.Left = dashboardButton.Left;
            dashboardButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            Dashboard dashboardform = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardform.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(dashboardform);
            dashboardform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = dashboardButton.Height;
            PnlNav.Top = dashboardButton.Top;
            PnlNav.Left = dashboardButton.Left;
            dashboardButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            Dashboard dashboardform = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            dashboardform.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(dashboardform);
            dashboardform.Show();
        }

        private void bodyGalleryButton_Click(object sender, EventArgs e)
        {
            dashboardButton_Leave(sender, e);
            PnlNav.Height = bodyGalleryButton.Height;
            PnlNav.Top = bodyGalleryButton.Top;
            PnlNav.Left = bodyGalleryButton.Left;
            bodyGalleryButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Body gallery";
            this.PnlFormLoader.Controls.Clear();
            BodyGallery bodygalleryform = new BodyGallery() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            bodygalleryform.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(bodygalleryform);
            bodygalleryform.Show();
        }

        private void foodGalleryButton_Click(object sender, EventArgs e)
        {
            dashboardButton_Leave(sender, e);
            PnlNav.Height = foodGalleryButton.Height;
            PnlNav.Top = foodGalleryButton.Top;
            PnlNav.Left = foodGalleryButton.Left;
            foodGalleryButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Food gallery";
            this.PnlFormLoader.Controls.Clear();
            FoodGallery foodgalleryform = new FoodGallery() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            foodgalleryform.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(foodgalleryform);
            foodgalleryform.Show();
        }

        private void smoothiesButton_Click(object sender, EventArgs e)
        {
            dashboardButton_Leave(sender, e);
            PnlNav.Height = smoothiesButton.Height;
            PnlNav.Top = smoothiesButton.Top;
            PnlNav.Left = smoothiesButton.Left;
            smoothiesButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Smoothies";
            this.PnlFormLoader.Controls.Clear();
            Smoothies smoothiesform = new Smoothies() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            smoothiesform.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(smoothiesform);
            smoothiesform.Show();
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            dashboardButton_Leave(sender, e);
            PnlNav.Height = monthButton.Height;
            PnlNav.Top = monthButton.Top;
            PnlNav.Left = monthButton.Left;
            monthButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Month summary";
            this.PnlFormLoader.Controls.Clear();
            MonthSummary monthsummaryform = new MonthSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            monthsummaryform.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(monthsummaryform);
            monthsummaryform.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            dashboardButton_Leave(sender, e);
            PnlNav.Height = settingsButton.Height;
            PnlNav.Top = settingsButton.Top;
            PnlNav.Left = settingsButton.Left;
            settingsButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            Settings settingsform = new Settings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            settingsform.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(settingsform);
            settingsform.Show();
        }

        private void dashboardButton_Leave(object sender, EventArgs e)
        {
            dashboardButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void bodyGalleryButton_Leave(object sender, EventArgs e)
        {
            bodyGalleryButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void foodGalleryButton_Leave(object sender, EventArgs e)
        {
            foodGalleryButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void smoothiesButton_Leave(object sender, EventArgs e)
        {
            smoothiesButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void monthButton_Leave(object sender, EventArgs e)
        {
            monthButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void settingsButton_Leave(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
