using Dietaverse.Database;
using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    public class Dishes_gallery
    {
        public Dishes_gallery()
        {
            this.users = new HashSet<users>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string recipe { get; set; }
        public int kcal { get; set; }
        public string photo { get; set; }

        public virtual ICollection<users> users { get; set; }

        public List<dishes_gallery> listOfPhotos(users presentuser)
        {
            using (var db = new db_modelContainer())
            {
                var photos = db.dishes_gallerySet;
                var list = new List<dishes_gallery>();
                foreach (var i in photos)
                {
                    list.Add(i);
                }
                return list;
            }
        }

        public void addPhoto(string _path, string _name,string _recipe, int _kcal_amount, users _u)
        {
            using (var db = new db_modelContainer())
            {
   
                dishes_gallery newphoto = new dishes_gallery();
                var u = db.usersSet;
                //users udg = new users_dishes_gallery() { users = _u, dishes_gallery = newphoto };
                newphoto.photo = _path;
                newphoto.name = _name;
                newphoto.recipe = _recipe;
                newphoto.kcal = _kcal_amount;
                newphoto.users = u.Single(a => a.name == _u.name);

                //db.users_dishes_gallerySet.Add(udg);
                db.dishes_gallerySet.Add(newphoto);
                db.SaveChanges();
            }
        }
    }
}
