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
        public virtual months months { get; set; }


        public Daily_summary() { }

        public void create(double _weight, int _kcal, users _u)
        {
            using(var db = new db_modelContainer())
            {
                var u = db.usersSet;
                daily_summary daily_Summary = new daily_summary();
                daily_Summary.kcal_amount = _kcal;
                daily_Summary.weight = _weight;
                daily_Summary.users = u.Single(a => a.name == _u.name);
                db.daily_summarySet.Add(daily_Summary);
                db.SaveChanges();
            }
        }

        public void create(double _weight, int _kcal, users _u, string _note)
        {
            using (var db = new db_modelContainer())
            {
                var u = db.usersSet;
                daily_summary daily_Summary = new daily_summary();
                daily_Summary.kcal_amount = _kcal;
                daily_Summary.weight = _weight;
                daily_Summary.notes = _note;
                daily_Summary.users = u.Single(a => a.name == _u.name);
                db.daily_summarySet.Add(daily_Summary);
                db.SaveChanges();
            }
        }
        public void update(double _weight, int _kcal, users _u)
        {
            using (var db = new db_modelContainer())
            {
                var u = db.usersSet;
                var summaries = db.daily_summarySet;
                daily_summary summary = null;


                foreach (var x in summaries)
                {
                    if (DateTime.Now == x.date)
                        summary = x;
                }

                if (summary == null)
                {
                    create(_weight, _kcal, _u);
                }

                //db.daily_summarySet.Add(daily_Summary);
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
                    if (DateTime.Now == x.date)
                        summary = x;
                }

                if(summary == null)
                {
                    create(_weight, _kcal, _u, _note);
                }

                else
                {
                    summary.weight = _weight;
                    summary.kcal_amount = _kcal;
                    summary.notes = _note;
                }

                //zapisac gdzies te zmiany????

                //foreach (var x in summaries)
                //{
                //    if (DateTime.Now == x.date)
                //        x = summary;
                //}

                //summary = u.Single(a => a.name == _u.name && DateTime.Now == );

                //db.daily_summarySet.Add(daily_Summary);
                db.SaveChanges();
            }
        }
    }
}
