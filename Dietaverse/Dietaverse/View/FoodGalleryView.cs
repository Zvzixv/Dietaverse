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
    public partial class FoodGalleryView : Form
    {
        DishesGallery fg = new DishesGallery();
        List<SmallPhoto> gallery = new List<SmallPhoto>();
        Form1 start;
        users user;
        public FoodGalleryView(Form1 _start, users _u)
        {
            InitializeComponent();
            start = _start;
            user = _u;

            List<dishes_gallery> dgs = fg.ListOfPhotos(user);

            foreach (dishes_gallery p in dgs)
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
            AddNewFoodPhoto addnewfoodphotoform = new AddNewFoodPhoto(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(addnewfoodphotoform);
        }

        public void ShowDescription(string recipe, string name)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.Text = "Name: " + name + "\n\nRecipe: " + recipe;
        }

        public void HideDescription()
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
            richTextBox1.Text = "Recipes will apear here...";
        }
    }
}
