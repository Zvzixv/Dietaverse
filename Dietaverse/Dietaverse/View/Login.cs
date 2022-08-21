﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dietaverse.View;

namespace Dietaverse.View
{
    public partial class Login : Form
    {
        mainForm mainform;
        public Login(mainForm mf)
        {
            InitializeComponent();
            mainform = mf;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 startform = new Form1(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            mainform.changeForm(startform);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}