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
        public static int calories = 10;
        public static int weight = 0;
        public Dashboard()
        {
            InitializeComponent();
            kcalLabel.Text =calories.ToString()+" kcal";
            weightLabel.Text =weight.ToString()+" kg";
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

        private void addcalButton_Click(object sender, EventArgs e)
        {
            int tempcal = 0;
            if (Int32.TryParse(caloriesTB.Text, out tempcal))
            {
                calories += tempcal;
                kcalLabel.Text = calories.ToString()+" kcal";
            }
            else
            {
                string message = "It is not a proper amount of calories.";
                MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(calories > 4000)
            {
                //zmienic kolor na czerwony
            }

            caloriesTB.Text = "";
           
        }

        private void changeweightButton_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(weightTB.Text, out weight))
            {
                weightLabel.Text = weight.ToString()+" kg";
            }

            weightTB.Text = "";
        }
    }
}
