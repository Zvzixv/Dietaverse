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
    public partial class BodyGallery : Form
    {

        List<SmallPhoto> gallery = new List<SmallPhoto>();
       
        public BodyGallery()
        {
            InitializeComponent();
            gallery.Add(new SmallPhoto() { TopLevel = false, TopMost = true });

            galleryPanel.Controls.Add(gallery[0]);
            gallery[0].Show();
            //gallery[0].pictureBox1.Click += new EventHandler((s, ee) => pictureBox1.Click(s, ee, i));
        }

        private void adNewPhotoButton_Click(object sender, EventArgs e)
        {
            gallery.Add(new SmallPhoto() { TopLevel = false, TopMost = true });

            galleryPanel.Controls.Add(gallery[gallery.Count]);
            gallery[gallery.Count].Show();
        }
    }
}
