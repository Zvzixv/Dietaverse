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
        double date;
        double weight;
        Image i;
        GUI g = new GUI();
        Body_gallery bg;
        Form1 start;
        users user;
        public AddNewBodyPhoto(Form1 upper, users user)
        {
            InitializeComponent();
            start = upper;
            this.user = user;
        }

        private void choosephotobutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                i = Image.FromFile(path);
                label7.Visible = false;
                pictureBox.Image = g.ResizeImage(i, pictureBox.Width, pictureBox.Height);
            }
            
        }

        private void adNewPhotoButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo filepathtemp = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString());
            string savepath = filepathtemp.ToString() + @"\Resources\";
            try
            {
                i.Save(savepath + Path.GetFileName(path));
            }
            catch (System.Runtime.InteropServices.ExternalException err)
            {

            }
            bg = new Body_gallery();
            bg.addPhoto(Path.GetFileName(path), note, DateTime.Today.ToString(), Dashboard.weight, user);
            MessageBox.Show(this, "Photo added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
            BodyGallery bodygalleryform = new BodyGallery(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(bodygalleryform);
        }
    }
}
