using Dietaverse.Database;
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
    public partial class FoodGallery : Form
    {
        Dishes_gallery fg = new Dishes_gallery();
        List<SmallPhoto> gallery = new List<SmallPhoto>();
        Form1 start;
        users user;
        public FoodGallery(Form1 _start, users _u)
        {
            InitializeComponent();
            start = _start;
            user = _u;

            List<dishes_gallery> dgs = fg.listOfPhotos(user);

            foreach (dishes_gallery p in dgs)
            {
                gallery.Add(new SmallPhoto(p) { TopLevel = false, TopMost = true });
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
            AddNewFoodPhoto addnewfoodphotoform = new AddNewFoodPhoto(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(addnewfoodphotoform);
        }
    }
}
