﻿using Dietaverse.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Dietaverse.Model
{

    public class AddPhotoFailException : Exception
    {
        public AddPhotoFailException() { }
        public AddPhotoFailException(string message) : base(message) { }
    }
    public class BodyGallery
    {
        public int Id { get; set; }
        public string photo { get; set; }
        public double weight { get; set; }
        public System.DateTime date { get; set; }

        public virtual users users { get; set; }
        public virtual photos photos { get; set; }

        public List<body_gallery> ListOfPhotos(users presentuser)
        {
            using (var db = new db_modelContainer())
            {
                var photos = db.body_gallerySet;
                var list = new List<body_gallery>();
                foreach(var i in photos)
                {
                    if(i.users.Id==presentuser.Id && i.photos.Id>-1)
                        list.Add(i);
                }
                return list;
            }
        }

        public void AddPhoto(string path, string note, string date, double weight, users user)
        {
            using (var db = new db_modelContainer())
            {
                var u = db.usersSet;

                String FileName = Path.GetFileName(path);
                byte[] AsBytes = File.ReadAllBytes(path);
                String DataAsBase64String = Convert.ToBase64String(AsBytes);

                if(AsBytes.Length>100000)
                {
                    throw new AddPhotoFailException("File is too big.");
                }

                photos photo = new photos();
                photo.filename = FileName;
                photo.data = DataAsBase64String;
                db.photosSet.Add(photo);
                

                body_gallery newEntry = new body_gallery();
                newEntry.date = date;
                newEntry.note = note;
                newEntry.weight = weight;
                newEntry.users = u.Single(a=>a.name == user.name);
                newEntry.photos = photo;

                db.body_gallerySet.Add(newEntry);
                db.SaveChanges();
            }
        }

       public void DeletePhoto(body_gallery tr)
       {
            using (var db = new db_modelContainer())
            {
                var bg = db.body_gallerySet;
                body_gallery toRemove = bg.Single((a => a.Id == tr.Id));
                db.body_gallerySet.Remove(toRemove);
                db.SaveChanges();
            }

       }
    }
}
