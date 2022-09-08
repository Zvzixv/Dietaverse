using Dietaverse.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class BodyGallery : Form
    {
        Body_gallery bg = new Body_gallery();
        List<SmallPhoto> gallery = new List<SmallPhoto>();
        Form1 start;
        users user;
       
        public BodyGallery(Form1 upper, users _user)
        {
            InitializeComponent();
            start = upper;
            user = _user;
            //List<body_gallery> bgs = bg.listOfPhotos();

            //foreach (body_gallery p in bgs)
            //{
            //    SmallPhoto part = new SmallPhoto(p);
            //    gallery.Add(part);
            //}

            //foreach (var i in gallery)
            //{
            //    gallery.Add(new SmallPhoto() { TopLevel = false, TopMost = true });
            //    galleryPanel.Controls.Add(i);
            //    i.Show();
            //}
            refresh();
        }

        private void refresh ()
        {
            List<body_gallery> bgs = bg.listOfPhotos();

            foreach (body_gallery p in bgs)
            {
                //SmallPhoto part = new SmallPhoto(p);
                gallery.Add(new SmallPhoto(p) { TopLevel = false, TopMost = true });
            }

            foreach (var i in gallery)
            {
                //gallery.Add(new SmallPhoto() { TopLevel = false, TopMost = true });
                galleryPanel.Controls.Add(i);
                i.Show();
            }
        }

        private void adNewPhotoButton_Click(object sender, EventArgs e)
        {
            start.PnlFormLoader.Controls.Clear();
            AddNewBodyPhoto addnewbodyphotoform = new AddNewBodyPhoto(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(addnewbodyphotoform);
        }
    }
}
