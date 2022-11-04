using Dietaverse.Database;
using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    public class Daily_summary
    {
        public int Id { get; set; }
        public string kcal_amount { get; set; }
        public double weight { get; set; }
        public string notes { get; set; }

        public virtual users users { get; set; }


        public Daily_summary() { }

        public void create(double _weight, int _kcal, users _u, string _note)
        {
            using (var db = new db_modelContainer())
            {
                var u = db.usersSet;
                daily_summary daily_Summary = new daily_summary();
                daily_Summary.kcal_amount = _kcal;
                daily_Summary.weight = _weight;
                daily_Summary.notes = _note;
                daily_Summary.date = DateTime.Now;
                daily_Summary.users = u.Single(a => a.name == _u.name);
                db.daily_summarySet.Add(daily_Summary);
                db.SaveChanges();
            }
        }

        public void create(double _weight, int _kcal, users _u, string _note, DateTime date)
        {
            using (var db = new db_modelContainer())
            {
                var u = db.usersSet;
                daily_summary daily_Summary = new daily_summary();
                daily_Summary.kcal_amount = _kcal;
                daily_Summary.weight = _weight;
                daily_Summary.notes = _note;
                daily_Summary.date = date;
                daily_Summary.users = u.Single(a => a.name == _u.name);
                db.daily_summarySet.Add(daily_Summary);
                db.SaveChanges();
            }
        }

        public void update(double _weight, int _kcal, users _u, string _note)
        {
            using (var db = new db_modelContainer())
            {
                var u = db.usersSet;
                var summaries = db.daily_summarySet;
                daily_summary summary=null;


                foreach(var x in summaries)
                {
                    if (DateTime.Now.Day == x.date.Day && DateTime.Now.Month == x.date.Month && DateTime.Now.Year == x.date.Year&&x.users.Id==_u.Id)
                        summary = x;
                }

                if(summary == null)
                {
                    create(_weight, _kcal, _u, _note);
                    return;
                }

                else
                {
                    summary.weight = _weight;
                    summary.kcal_amount = _kcal;
                    if(_note!= "You can leave some notes here...")
                        summary.notes = _note;
                }

                db.SaveChanges();
            }
        }
         public int downloadKcalFromDatabase(users us, DateTime day)
         {

            using (var db = new db_modelContainer())
            {
                var users = db.usersSet;
                var summaries = db.daily_summarySet;

                daily_summary searchedsummary;

                try
                {
                    searchedsummary = summaries.Single(a => a.users.name == us.name && a.date.Day == day.Day && a.date.Month == day.Month && a.date.Year == day.Year);
                }
                catch (Exception ex)
                {
                    return 0;
                }

                return (int)searchedsummary.kcal_amount;
            }
        }

        public double downloadWeightFromDatabase(users us, DateTime day)
        {

            using (var db = new db_modelContainer())
            {
                var users = db.usersSet;
                var summaries = db.daily_summarySet;
                daily_summary searchedsummary;

                try
                {
                    searchedsummary = summaries.Single(a => a.users.name == us.name && a.date.Day == day.Day && a.date.Month == day.Month && a.date.Year == day.Year);
                }
                catch (Exception ex)
                {
                    return -1;
                }

                return (double)searchedsummary.weight;
            }
        }

        public string downloadNoteFromDatabase(users us, DateTime day)
        {

            using (var db = new db_modelContainer())
            {
                var users = db.usersSet;
                var summaries = db.daily_summarySet;

                daily_summary searchedsummary;
                //users user = users.Single(a=>a.name == us.name);
                try
                {
                    searchedsummary = summaries.Single(a => a.users.name == us.name && a.date.Day == day.Day && a.date.Month == day.Month && a.date.Year == day.Year);
                }
                catch (Exception ex)
                {
                    return "";
                }

                return (string)searchedsummary.notes;
            }
        }

        //kazdy dzien ktory nie jest zapisany ma miec dane z ostatniego zapisanego dnia (kilogramy) i zero kalorii 

        //mozliwe, ze zbedne
        //public void fillOtherDays(users us)
        //{
        //    using (var db = new db_modelContainer())
        //    {
        //        var users = db.usersSet;
        //        var summaries = db.daily_summarySet;

        //        DateTime start = new DateTime(2022, 9, 1, 0, 0, 0);
        //        DateTime today = DateTime.Now;
        //        daily_summary lastSaved = null;

        //        TimeSpan difference = today - start;
        //        int differenceInDays = (int)difference.TotalDays;

        //        daily_summary searchedsummary = null;


        //        cos jest nie tak z petla. Tworzy sie dzien ale tylko jeden meh

        //                for (int i = 0; i < differenceInDays; i++)
        //        {
        //            try
        //            {
        //                //jest ten dzien?
        //                searchedsummary = summaries.Single(a => a.users.name == us.name && a.date.Day == start.Day && a.date.Month == start.Month && a.date.Year == start.Year);
        //            }

        //            catch (Exception ex)
        //            {
        //                //nie ma tego dnia
        //                daily_summary newday = new daily_summary();
        //                newday.users = us;
        //                newday.date = start;
        //                if (lastSaved != null)
        //                {
        //                    newday.kcal_amount = lastSaved.kcal_amount;
        //                    newday.weight = lastSaved.weight;
        //                }
        //                else
        //                {
        //                    newday.kcal_amount = 0;
        //                    newday.weight = 0;
        //                }

        //                create((int)newday.weight, (int)newday.kcal_amount, us, null, newday.date);

        //                start.AddDays(1);
        //                break;

        //            }

        //            //jeeest
        //            lastSaved = searchedsummary;

        //            start.AddDays(1);

        //        }
        //    }
        //}
    }
}
