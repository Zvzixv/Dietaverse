using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Drawing;
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
        DishesGallery dg;

        bool nametextboxcliced = false;
        bool recipetextboxblicked = false;
        bool kcaltextboxclicker = false;
        public AddNewFoodPhoto(Form1 _start, users _u)
        {
            InitializeComponent();
            user = _u;
            start = _start;

            nameTextBox.Text = "Insert name here";
            recipetextBox.Text = "Insert recipe here";
            kcaltextBox.Text = "Insert kcal here";
        }

        private void choosephotobutton_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                i = Image.FromFile(path);
                label7.Visible = false;
                pictureBox.Image = i;
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
            dg = new DishesGallery();
            try
            {
                dg.AddPhoto(path, name, recipe, kcal, user);
            }
            catch(AddPhotoFailException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(this, "Photo added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
            FoodGalleryView foodgalleryform = new FoodGalleryView(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.ChangeForm(foodgalleryform);
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if(!nametextboxcliced)
            {
                nameTextBox.Text = "";
                nametextboxcliced = true;
                nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Regular);
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if(nametextboxcliced && nameTextBox.TextLength==0)
            {
                nameTextBox.Text = "Insert name here";
                nametextboxcliced= false;
                nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Italic);

            }
        }

        private void recipetextBox_Enter(object sender, EventArgs e)
        {
            if (!recipetextboxblicked)
            {
                recipetextBox.Text = "";
                recipetextboxblicked = true;
                recipetextBox.Font = new Font(recipetextBox.Font, FontStyle.Regular);
            }
        }

        private void recipetextBox_Leave(object sender, EventArgs e)
        {
            if (recipetextboxblicked && recipetextBox.TextLength == 0)
            {
                recipetextBox.Text = "Insert recipe here";
                recipetextboxblicked = false;
                recipetextBox.Font = new Font(recipetextBox.Font, FontStyle.Italic);

            }
        }

        private void kcaltextBox_Enter(object sender, EventArgs e)
        {
            if (!kcaltextboxclicker)
            {
                kcaltextBox.Text = "";
                kcaltextboxclicker = true;
                kcaltextBox.Font = new Font(kcaltextBox.Font, FontStyle.Regular);
            }
        }

        private void kcaltextBox_Leave(object sender, EventArgs e)
        {
            if (kcaltextboxclicker && kcaltextBox.TextLength == 0)
            {
                kcaltextBox.Text = "Insert kcal here";
                kcaltextboxclicker = false;
                kcaltextBox.Font = new Font(kcaltextBox.Font, FontStyle.Italic);

            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            FoodGalleryView foodgalleryform = new FoodGalleryView(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.ChangeForm(foodgalleryform);
        }
    }
}
