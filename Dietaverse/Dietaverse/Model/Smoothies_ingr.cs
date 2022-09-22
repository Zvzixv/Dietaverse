using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    class Smoothies_ingr
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double kcal { get; set; }

        public void addNewIngr(string name, string kcal)
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

        public List<Smoothies_ingr> makeAList()
        {
            using(var db=new db_modelContainer())
            {
                List<Smoothies_ingr> newlist = new List<Smoothies_ingr>();

                var x = db.smoothies_ingrSet;
                foreach(var i in x)
                {
                    Smoothies_ingr n = new Smoothies_ingr();
                    n.name = i.name;
                    n.kcal = i.kcal;
                    newlist.Add(n);
                }
                return newlist;
            }
        }
    }
}
