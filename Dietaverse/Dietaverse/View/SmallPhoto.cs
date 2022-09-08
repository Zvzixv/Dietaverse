using Dietaverse.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class SmallPhoto : Form
    {
        bool isPhotoClicked = false;
        string note="";
        private GUI g = new GUI();
        public SmallPhoto()
        {
            InitializeComponent();
            description.Visible = false;
        }

        public SmallPhoto(body_gallery bg)
        {
            InitializeComponent();
            description.Visible = false;

            System.IO.DirectoryInfo filepathtemp = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString());
            string filepath = filepathtemp.ToString() + @"\Resources\";
            Image photoImage = Image.FromFile(filepath + bg.photo);

            pictureBox1 = new PictureBox();
            pictureBox1.Image = g.ResizeImage(photoImage, pictureBox1.Width, pictureBox1.Height);
            description.Text =  bg.date.ToString();
            note = bg.note;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPhotoClicked == false)
            {
                description.Visible = true;
                isPhotoClicked = true;
            }
            else if(isPhotoClicked == true)
            {
                description.Visible=false;
                isPhotoClicked=false;
            }
        }

        public void description_Click(object sender, EventArgs e)
        {
            description.Visible = false;
        }
    }
}
