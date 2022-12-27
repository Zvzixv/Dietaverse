using Dietaverse.Database;
using Dietaverse.Model;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        DailySummary summary = new DailySummary();
        public Dashboard(users _user)
        {
            user = _user;
            weight = findLastWeight(DateTime.Now);
            calories = summary.DownloadKcalFromDatabase(user, DateTime.Now);

            InitializeComponent();

            if(summary.DownloadNoteFromDatabase(user, DateTime.Now)!=""&& summary.DownloadNoteFromDatabase(user, DateTime.Now) != null)
            {
                notes = summary.DownloadNoteFromDatabase(user,DateTime.Now);
                richTextBox1.Text = notes;
            }
            else
                richTextBox1.Text = "Możesz tutaj wpisać swoje notatki...";


            kcalLabel.Text =calories.ToString()+" kcal";
            weightLabel.Text =weight.ToString()+" kg";

            chartManage();

            cartesianChart1.AxisX.Add(new Axis { MinValue = 1 });
            cartesianChart1.AxisY.Add(new Axis { MinValue = 0 });

        }

        private double findLastWeight(DateTime day)
        {
            DateTime tempday = day;
            double weight;

            while (summary.DownloadWeightFromDatabase(user, tempday) == -1 && tempday >= user.joindate)
            {
                tempday = tempday.AddDays(-1);
            }

            return summary.DownloadWeightFromDatabase(user, tempday);
        }

        private void chartManage()
        {
            List<ObservablePoint> points = new List<ObservablePoint>();

            points.Add(new ObservablePoint(5, summary.DownloadKcalFromDatabase(user, DateTime.Now)));
            if (user.joindate < DateTime.Now.AddDays(-1)) points.Add(new ObservablePoint(4, summary.DownloadKcalFromDatabase(user, DateTime.Now.AddDays(-1))));
            if (user.joindate < DateTime.Now.AddDays(-2)) points.Add(new ObservablePoint(3, summary.DownloadKcalFromDatabase(user, DateTime.Now.AddDays(-2))));
            if (user.joindate < DateTime.Now.AddDays(-3)) points.Add(new ObservablePoint(2, summary.DownloadKcalFromDatabase(user, DateTime.Now.AddDays(-3))));
            if (user.joindate < DateTime.Now.AddDays(-4)) points.Add(new ObservablePoint(1, summary.DownloadKcalFromDatabase(user, DateTime.Now.AddDays(-4))));

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>(points)
                    {

                    }
                }
            };

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
                richTextBox1.Text = "Możesz tutaj wpisać swoje notatki...";
                hasBeenClicked=false;
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
                notes = "";
            }

            summary.Update(weight, calories, user, notes);
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
                string message = "To nie jest poprawna wartość kalorii.";
                MessageBox.Show(this, message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(calories > 4000)
            {
                //zmienic kolor na czerwony
            }

            caloriesTB.Text = "";
            summary.Update(weight, calories, user, notes);
            chartManage();

        }

        private void changeweightButton_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(weightTB.Text, out weight))
            {
                weightLabel.Text = weight.ToString()+" kg";
            }

            weightTB.Text = "";
            summary.Update(weight, calories, user, notes);
            User.ChangeWeight(user, weight);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            notes = richTextBox1.Text;
        }
    }
}
