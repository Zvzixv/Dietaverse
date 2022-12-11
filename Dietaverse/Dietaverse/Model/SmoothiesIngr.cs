using Dietaverse.Database;
using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    public class SmoothiesIngr
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double kcal { get; set; }

        public void AddNewIngr(string name, string kcal)
        {
            using(var db = new db_modelContainer())
            {
                smoothies_ingr newingr = new smoothies_ingr();
                newingr.name = name;
                newingr.kcal = Double.Parse(kcal);
                db.smoothies_ingrSet.Add(newingr);
                db.SaveChanges();
            }
        }

        public List<SmoothiesIngr> MakeAList()
        {
            using(var db=new db_modelContainer())
            {
                List<SmoothiesIngr> newlist = new List<SmoothiesIngr>();

                var x = db.smoothies_ingrSet;
                foreach(var i in x)
                {
                    SmoothiesIngr n = new SmoothiesIngr();
                    n.name = i.name;
                    n.kcal = i.kcal;
                    newlist.Add(n);
                }
                return newlist;
            }
        }

    }
}
