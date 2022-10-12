using Dietaverse.Database;
using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    class Body_gallery
    {
        public int Id { get; set; }
        public string photo { get; set; }
        public double weight { get; set; }
        public System.DateTime date { get; set; }

        public virtual users users { get; set; }

        public List<body_gallery> listOfPhotos(users presentuser)
        {
            using (var db = new db_modelContainer())
            {
                var photos = db.body_gallerySet;
                var list = new List<body_gallery>();
                foreach(var i in photos)
                {
                    if(i.users.Id==presentuser.Id)
                        list.Add(i);
                }
                return list;
            }
        }

        public void addPhoto(string path, string note, string date, double weight, users user)
        {
            using (var db = new db_modelContainer())
            {
                var u = db.usersSet;

                body_gallery newphoto = new body_gallery();
                newphoto.photo = path;
                newphoto.date = DateTime.Today;
                newphoto.note = note;
                newphoto.weight = weight;
                newphoto.users = u.Single(a=>a.name == user.name);

                db.body_gallerySet.Add(newphoto);
                db.SaveChanges();
            }
        }
        
        public bool editPhoto(string path, string note)
        {
            using (var db = new db_modelContainer())
            {
                var p = db.body_gallerySet.Single(x => x.photo == path);
                p.note = note;
                db.SaveChanges();
                return true;
            }
        }

    }
}
