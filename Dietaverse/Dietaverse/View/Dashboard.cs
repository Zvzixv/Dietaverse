using Dietaverse.Database;
using Dietaverse.Model;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
            weight = findLastWeight(DateTime.Now);
            calories = summary.downloadKcalFromDatabase(user, DateTime.Now);
            if(summary.downloadNoteFromDatabase(user, DateTime.Now)!="")
            {
                notes = summary.downloadNoteFromDatabase(user,DateTime.Now);
            }
            InitializeComponent();
            richTextBox1.Text = notes;
            kcalLabel.Text =calories.ToString()+" kcal";
            weightLabel.Text =weight.ToString()+" kg";

            chartManage();

        }

        private double findLastWeight(DateTime day)
        {
            DateTime tempday = day;
            double weight;

            while (summary.downloadWeightFromDatabase(user, tempday) == -1 && tempday >= user.joindate)
            {
                tempday = tempday.AddDays(-1);
            }

            return summary.downloadWeightFromDatabase(user, tempday);
        }

        private void chartManage()
        {



            //cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Days",
            //    Labels = new[] { "5 days ago", "4 days ago", "3 days ago", "2 days ago", "yesterday", "today" }
            //});

            //cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Kcal",
            //    Labels = new[] {summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-5)).ToString(),
            //    summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-4)).ToString(),
            //    summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-3)).ToString(),
            //    summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-2)).ToString(),
            //    summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-1)).ToString(),
            //    summary.downloadKcalFromDatabase(user, DateTime.Now).ToString()}

            //});

            cartesianChart1.AxisX.Add(new Axis { MinValue = 1 });
            cartesianChart1.AxisY.Add(new Axis { MinValue = 0 });

            List<ObservablePoint> points = new List<ObservablePoint>();

            points.Add(new ObservablePoint(5, summary.downloadKcalFromDatabase(user, DateTime.Now)));
            if (user.joindate < DateTime.Now.AddDays(-1)) points.Add(new ObservablePoint(4, summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-1))));
            if (user.joindate < DateTime.Now.AddDays(-2)) points.Add(new ObservablePoint(3, summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-2))));
            if (user.joindate < DateTime.Now.AddDays(-3)) points.Add(new ObservablePoint(2, summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-3))));
            if (user.joindate < DateTime.Now.AddDays(-4)) points.Add(new ObservablePoint(1, summary.downloadKcalFromDatabase(user, DateTime.Now.AddDays(-4))));

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>(points)
                    {

                    }
                }
            };

            

            //cartesianChart1.AxisX.ShowLabels = false;

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

            summary.update(weight, calories, user, notes);
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
            chartManage();

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
