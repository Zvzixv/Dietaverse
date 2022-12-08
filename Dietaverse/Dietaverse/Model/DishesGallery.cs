using Dietaverse.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dietaverse.Model
{
    public class DishesGallery
    {
        public DishesGallery()
        {
            this.users = new HashSet<users>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string recipe { get; set; }
        public int kcal { get; set; }
        public string photo { get; set; }

        public virtual ICollection<users> users { get; set; }

        public List<dishes_gallery> ListOfPhotos(users presentuser)
        {
            using (var db = new db_modelContainer())
            {
                var photos = db.dishes_gallerySet;
                var list = new List<dishes_gallery>();
                foreach (var i in photos)
                {
                    if(i.photos.Id >-1)
                    list.Add(i);
                }
                return list;
            }
        }

        public void AddPhoto(string _path, string _name,string _recipe, int _kcal_amount, users _u)
        {
            using (var db = new db_modelContainer())
            {
   
                dishes_gallery newEntry = new dishes_gallery();
                var u = db.usersSet;
                //users udg = new users_dishes_gallery() { users = _u, dishes_gallery = newphoto };

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

                newEntry.name = _name;
                newEntry.recipe = _recipe;
                newEntry.kcal = _kcal_amount;
                newEntry.users = u.Single(a => a.name == _u.name);
                newEntry.photos = photo;

                db.dishes_gallerySet.Add(newEntry);
                db.SaveChanges();
            }
        }

        public void DeletePhoto(dishes_gallery tr)
        {
            using (var db = new db_modelContainer())
            {
                var dg = db.dishes_gallerySet;
                dishes_gallery toRemove = dg.Single((a => a.Id == tr.Id));
                db.dishes_gallerySet.Remove(toRemove);
                db.SaveChanges();
            }

        }
    }
}

