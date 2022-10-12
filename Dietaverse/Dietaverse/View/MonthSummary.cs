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
    public partial class MonthSummary : Form
    {
        users _user;
        Daily_summary _daily_summary = new Daily_summary();
        public MonthSummary(users user)
        {
            InitializeComponent();
            _user = user;
            datelabelOut.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            monthCalendar1.MaxDate = DateTime.Today;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            datelabelOut.Text = e.Start.Day.ToString() +"."+e.Start.Month.ToString()+ "." + e.Start.Year.ToString();

            //TO DO: to tylko workaround --- trzeba zrobic funkcje ktora sprawdza ostatnia podana wage i tu wpisac
            weightlabelOut.Text = _daily_summary.downloadWeightFromDatabase(_user, e.Start)==-1 ? "Not inserted": _daily_summary.downloadWeightFromDatabase(_user, e.Start).ToString();

            callabelOut.Text = _daily_summary.downloadKcalFromDatabase(_user, e.Start).ToString();

        }
    }
}
