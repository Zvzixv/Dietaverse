using System;
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
    public partial class Smoothies : Form
    {
        Form1 start;
        public Smoothies(Form1 _start)
        {
            start = _start;
            InitializeComponent();
        }

        private smoothies_recipes algorithm()
        {
            smoothies_recipes result = new smoothies_recipes();
            int confidence = 0;


            return result;
        }

        private void addNewbutton1_Click(object sender, EventArgs e)
        {
            start.PnlFormLoader.Controls.Clear();
            AddNewSmoothie addnewsmoothieform = new AddNewSmoothie(start) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(addnewsmoothieform);
        }
    }
}
