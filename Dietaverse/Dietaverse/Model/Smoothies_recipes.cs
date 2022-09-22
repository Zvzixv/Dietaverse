﻿using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    internal class Smoothies_recipes
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public string smoothies_ingr { get; set; }
        public string kcal { get; set; }
        public bool fruity { get; set; }
        public bool vegetable { get; set; }
        public bool sweet { get; set; }
        public bool sour { get; set; }


        public void addNewSmoothie(string name, string photo, List<Smoothies_ingr> smoothies_ingr, string kcal, bool fruity, bool vegtable, bool sweet, bool sour)
        {
            using (var db = new db_modelContainer())
            {
                var ing = db.smoothies_ingrSet;

                smoothies_recipes sr = new smoothies_recipes();
                sr.name = name;
                sr.photo = photo;
                sr.fruity = fruity;
                sr.vegetable = vegtable;
                sr.sweet = sweet;
                sr.sour = sour;

                foreach(var i in smoothies_ingr)
                {
                    recipes_ingredient ri = new recipes_ingredient();
                    ri.smoothies_ingr = ing.Single(a => a.name == i.name);
                    sr.recipes_ingredient.Add(ri);

                }
                db.smoothies_recipesSet.Add(sr);
                db.SaveChanges();

            }
        }
    }
}