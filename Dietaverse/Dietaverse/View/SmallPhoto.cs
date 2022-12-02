using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class SmallPhoto : Form
    {
        bool isPhotoClicked = false;

        //body gallery
        string note="";
        double weight;

        //food gallery
        string name;
        string recipe;
        int kcal;

        private GUI g = new GUI();
        BodyGalleryView upperform = null;
        FoodGalleryView upperformFood = null;

        public SmallPhoto()
        {
            InitializeComponent();
            description.Visible = false;
        }

        public SmallPhoto(body_gallery bg, BodyGalleryView form)
        {
            InitializeComponent();
            description.Visible = false;
            upperform = form;

            photos photo = bg.photos;

            byte [] tempBytes = Convert.FromBase64String(photo.data);
            MemoryStream memStr = new MemoryStream(tempBytes);
            Image photoImage = Image.FromStream(memStr);

            pictureBox1.Image = g.ResizeImage(photoImage, pictureBox1.Width, pictureBox1.Height);
            description.Text =  bg.date;
            description.TextAlign = ContentAlignment.MiddleLeft;
            note = bg.note;
            weight = bg.weight;
        }

        public SmallPhoto(dishes_gallery dg, FoodGalleryView form)
        {
            InitializeComponent();
            description.Visible = false;
            upperformFood = form;

            photos photo = dg.photos;

            byte[] tempBytes = Convert.FromBase64String(photo.data);
            MemoryStream memStr = new MemoryStream(tempBytes);
            Image photoImage = Image.FromStream(memStr);

            pictureBox1.Image = g.ResizeImage(photoImage, pictureBox1.Width, pictureBox1.Height);

            name = dg.name;
            recipe = dg.recipe;
            kcal = (int)dg.kcal;
            description.Text = "Kcal: "+kcal.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPhotoClicked == false&&upperform==null)
            {
                description.Visible = true;
                isPhotoClicked = true;
                upperformFood.ShowDescription(recipe, name);
            }
            else if(isPhotoClicked == true&&upperform==null)
            {
                description.Visible=false;
                isPhotoClicked=false;
                upperformFood.HideDescription();
            }

            if (isPhotoClicked == false && upperform != null)
            {
                description.Visible = true;
                isPhotoClicked = true;
                upperform.ShowDescription(note, weight);
            }
            else if (isPhotoClicked == true && upperform != null)
            {
                description.Visible = false;
                isPhotoClicked = false;
                upperform.HideDescription();
            }
        }

        private void description_Click(object sender, EventArgs e)
        {
            description.Visible = false;
        }
    }
}
