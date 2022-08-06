using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class Dashboard : Form
    {
        bool hasBeenClicked = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void richTextBox1_Validated(object sender, EventArgs e)
        {
            if (!hasBeenClicked)
            {
                richTextBox1.Text = "";
                hasBeenClicked = true;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if(hasBeenClicked&&richTextBox1.TextLength == 0)
            {
                richTextBox1.Text = "You can left some notes here...";
                hasBeenClicked=false;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
            }
        }
    }
}
