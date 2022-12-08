using Dietaverse.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class BodyGalleryView : Form
    {
        Model.BodyGallery bg = new Model.BodyGallery();
        List<SmallPhoto> gallery = new List<SmallPhoto>();
        Form1 start;
        users user;

        public BodyGalleryView(Form1 upper, users _user)
        {
            InitializeComponent();
            start = upper;
            user = _user;
            List<body_gallery> bgs = bg.ListOfPhotos(user);

            foreach (body_gallery p in bgs)
            {
                gallery.Add(new SmallPhoto(p, this) { TopLevel = false, TopMost = true });
            }

            foreach (var i in gallery)
            {
                galleryPanel.Controls.Add(i);
                i.Show();
            }
        }


        private void adNewPhotoButton_Click(object sender, EventArgs e)
        {
            start.PnlFormLoader.Controls.Clear();
            AddNewBodyPhoto addnewbodyphotoform = new AddNewBodyPhoto(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.ChangeForm(addnewbodyphotoform);
        }

        public void ShowDescription(string notes, double weight)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.Text = "Contemporary weight: " + weight + " \n" + notes;
        }

        public void HideDescription()
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
            richTextBox1.Text = "Your notes will appear here...";
        }

    }
}
