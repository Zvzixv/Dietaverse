using Dietaverse.Database;
using Dietaverse.Model;
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
        public static int calories = 0;
        public static double weight = 0;
        users user;
        Users User = new Users();
        string notes;
        Daily_summary summary = new Daily_summary();
        public Dashboard(users _user)
        {
            user = _user;
            weight = user.weight;
            calories = summary.downloadKcalFromDatabase(user, DateTime.Now);
            if(summary.downloadNoteFromDatabase(user, DateTime.Now)!="")
            {
                notes = summary.downloadNoteFromDatabase(user,DateTime.Now);
            }
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
                richTextBox1.Text = "You can leave some notes here...";
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
            summary.update(weight, calories, user, notes);
           
        }

        private void changeweightButton_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(weightTB.Text, out weight))
            {
                weightLabel.Text = weight.ToString()+" kg";
            }

            weightTB.Text = "";
            summary.update(weight, calories, user, notes);
            User.ChangeWeight(user, weight);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            notes = richTextBox1.Text;
        }
    }
}
