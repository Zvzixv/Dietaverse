using Dietaverse.Database;
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
    public partial class AddNewFoodPhoto : Form
    {
        Form1 start;
        users user;
        string path;
        string recipe;
        string name;
        int kcal;

        Image i;
        GUI g = new GUI();
        Dishes_gallery dg;
        public AddNewFoodPhoto(Form1 _start, users _u)
        {
            InitializeComponent();
            user = _u;
            start = _start;
        }

        private void choosephotobutton_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                i = Image.FromFile(path);
                label7.Visible = false;
                pictureBox.Image = g.ResizeImage(i, pictureBox.Width, pictureBox.Height);
            }
        }

        private void adNewPhotoButton_Click_1(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            recipe = recipetextBox.Text;
            try
            {
                kcal = Int32.Parse(kcaltextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Insert proper value.","Correct", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            dg = new Dishes_gallery();
            try
            {
                dg.addPhoto(path, name, recipe, kcal, user);
            }
            catch(AddPhotoFailException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(this, "Photo added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
            FoodGallery foodgalleryform = new FoodGallery(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(foodgalleryform);
        }
    }
}
