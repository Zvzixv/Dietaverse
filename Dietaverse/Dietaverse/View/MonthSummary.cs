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
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now;
            datelabelOut.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            richTextBox1.Text = _daily_summary.downloadNoteFromDatabase(_user, DateTime.Now);
            weightlabelOut.Text = _daily_summary.downloadWeightFromDatabase(_user, DateTime.Now).ToString();
            callabelOut.Text = _daily_summary.downloadKcalFromDatabase(_user, DateTime.Now).ToString();
            monthCalendar1.MaxDate = DateTime.Today;
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);

            if (richTextBox1.TextLength == 0)
            {
                richTextBox1.Text = "Notes will apear here...";
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            datelabelOut.Text = e.Start.Day.ToString() +"."+e.Start.Month.ToString()+ "." + e.Start.Year.ToString();

            weightlabelOut.Text = _daily_summary.downloadWeightFromDatabase(_user, e.Start)==-1 ? (findLastWeight(e.Start)!=-1? findLastWeight(e.Start).ToString(): "Not inserted") : _daily_summary.downloadWeightFromDatabase(_user, e.Start).ToString();

            callabelOut.Text = _daily_summary.downloadKcalFromDatabase(_user, e.Start).ToString();

            richTextBox1.Text = _daily_summary.downloadNoteFromDatabase(_user, e.Start);

            if (richTextBox1.TextLength == 0)
            {
                richTextBox1.Text = "Notes will apear here...";
            }
        }

        private double findLastWeight(DateTime day)
        {
            DateTime tempday = day;
            double weight;
            
            while (_daily_summary.downloadWeightFromDatabase(_user, tempday)==-1 && tempday>=_user.joindate)
            {
                tempday = tempday.AddDays(-1);
            }

            return _daily_summary.downloadWeightFromDatabase(_user, tempday);
        }
    }
}
