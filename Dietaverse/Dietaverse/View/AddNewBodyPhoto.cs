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
    public partial class AddNewBodyPhoto : Form
    {
        string path;
        string note;

        Image i;
        GUI g = new GUI();
        Body_gallery bg;
        Form1 start;
        users user;

        bool notetextboxclicked = false;
        public AddNewBodyPhoto(Form1 upper, users user)
        {
            InitializeComponent();
            start = upper;
            this.user = user;
            notetextBox.Text = "Insert note here";

        }

        private void choosephotobutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                i = Image.FromFile(path);
                label1.Visible = false;
                pictureBox.Image = i;//g.ResizeImage(i, pictureBox.Width, pictureBox.Height);
            }
            
        }

        private void adNewPhotoButton_Click(object sender, EventArgs e)
        {
            
            note = notetextBox.Text;
            //DirectoryInfo filepathtemp = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString());
            //string savepath = filepathtemp.ToString() + @"\Resources\";
            //try
            //{
            //    i.Save(savepath + Path.GetFileName(path));
            //}
            //catch (System.Runtime.InteropServices.ExternalException err)
            //{

            //}
            bg = new Body_gallery();
            try
            {
                bg.addPhoto(path, note, DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString(), Dashboard.weight, user);
            }
            catch(AddPhotoFailException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(this, "Photo added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
            BodyGallery bodygalleryform = new BodyGallery(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(bodygalleryform);
        }

        private void notetextBox_Enter(object sender, EventArgs e)
        {
            if (!notetextboxclicked)
            {
                notetextBox.Text = "";
                notetextboxclicked = true;
                notetextBox.Font = new Font(notetextBox.Font, FontStyle.Regular);
            }
        }

        private void notetextBox_Leave(object sender, EventArgs e)
        {
            if (notetextboxclicked && notetextBox.TextLength == 0)
            {
                notetextBox.Text = "Insert note here";
                notetextboxclicked = false;
                notetextBox.Font = new Font(notetextBox.Font, FontStyle.Italic);

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BodyGallery bodygalleryform = new BodyGallery(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(bodygalleryform);
        }
    }
}
