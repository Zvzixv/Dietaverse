using Dietaverse.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dietaverse.Model
{
    public class SmoothiesRecipes
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public bool fruity { get; set; }
        public bool vegetable { get; set; }
        public bool sweet { get; set; }
        public bool sour { get; set; }

        public List<smoothies_ingr> ingredients = new List<smoothies_ingr>();

        public virtual photos photos { get; set; }


        public void AddNewSmoothie(string name, string _path, List<SmoothiesIngr> smoothies_ingr,  bool fruity, bool vegtable, bool sweet, bool sour)
        {
            using (var db = new db_modelContainer())
            {
                var ing = db.smoothies_ingrSet;

                String FileName = Path.GetFileName(_path);
                byte[] AsBytes = File.ReadAllBytes(_path);
                String DataAsBase64String = Convert.ToBase64String(AsBytes);

                if (AsBytes.Length > 100000)
                {
                    throw new AddPhotoFailException("File is too big.");
                }

                photos photo = new photos();
                photo.filename = FileName;
                photo.data = DataAsBase64String;
                db.photosSet.Add(photo);

                smoothies_recipes sr = new smoothies_recipes();
                sr.name = name;
                sr.photos = photo;
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

        public double CalculateKcal(SmoothiesRecipes result)
        {
            using (var db = new db_modelContainer())
            {
                List <smoothies_ingr> ingrs = new List<smoothies_ingr>();
                ingrs = result.ingredients;
                double sum = 0;

                foreach(var i in ingrs)
                {
                    sum+= i.kcal;
                }

                return sum;
            }
        }
        public List<SmoothiesRecipes> MakeAList ()
        {
            using (var db = new db_modelContainer())
            {
                List<SmoothiesRecipes> smoothies_Recipes = new List<SmoothiesRecipes>();
                var rec = db.smoothies_recipesSet;

                if (rec != null)
                {

                    foreach (var i in rec)
                    {
                        SmoothiesRecipes smoothie = new SmoothiesRecipes();
                        smoothie.name = i.name;
                        smoothie.photos = i.photos;
                        smoothie.sour = i.sour;
                        smoothie.fruity = i.fruity;
                        smoothie.vegetable = i.vegetable;
                        smoothie.sweet = i.sweet;

                        foreach (var x in i.recipes_ingredient)
                        {
                            smoothie.ingredients.Add(x.smoothies_ingr);
                        }

                        smoothies_Recipes.Add(smoothie);

                    }
                }

                return smoothies_Recipes;
            }
        }

        public smoothies_recipes GetSmoothie(string name)
        {
            using (var db = new db_modelContainer())
            {
                var sr = db.smoothies_recipesSet.Where(a => a.name == name);
                return sr.FirstOrDefault();
            }
        }

        public void deleteSmoothie(string name)
        {
            using (var db = new db_modelContainer())
            {
                var u = db.smoothies_recipesSet;
                smoothies_recipes toDelete = u.Single(a => a.name == name);
                db.smoothies_recipesSet.Remove(toDelete);
                db.SaveChanges();
            }
        }

    }


}
