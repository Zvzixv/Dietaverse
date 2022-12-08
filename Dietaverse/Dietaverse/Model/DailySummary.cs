﻿using Dietaverse.Database;
using System;
using System.Linq;


namespace Dietaverse.Model
{
    public class DailySummary
    {
        public int Id { get; set; }
        public string kcal_amount { get; set; }
        public double weight { get; set; }
        public string notes { get; set; }

        public virtual users users { get; set; }


        public DailySummary() { }

        public void Create(double _weight, int _kcal, users _u, string _note)
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

        public void Update(double _weight, int _kcal, users _u, string _note)
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
                    Create(_weight, _kcal, _u, _note);
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
         public int DownloadKcalFromDatabase(users us, DateTime day)
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

        public double DownloadWeightFromDatabase(users us, DateTime day)
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

        public string DownloadNoteFromDatabase(users us, DateTime day)
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
                    return "";
                }

                return (string)searchedsummary.notes;
            }
        }

    }
}
