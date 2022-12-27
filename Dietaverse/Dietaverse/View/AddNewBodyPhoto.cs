using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class AddNewBodyPhoto : Form
    {
        string path;
        string note;

        Image i;
        GUI g = new GUI();
        Model.BodyGallery bg;
        Form1 start;
        users user;

        bool notetextboxclicked = false;
        public AddNewBodyPhoto(Form1 upper, users user)
        {
            InitializeComponent();
            start = upper;
            this.user = user;
            notetextBox.Text = "Wpisz tutaj notatkę";

        }

        private void choosephotobutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                i = Image.FromFile(path);
                label1.Visible = false;
                pictureBox.Image = g.ResizeImage(i, pictureBox.Width, pictureBox.Height);
            }
            
        }

        private void adNewPhotoButton_Click(object sender, EventArgs e)
        {
            
            note = notetextBox.Text;
            bg = new Model.BodyGallery();
            try
            {
                bg.AddPhoto(path, note, DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString(), Dashboard.weight, user);
            }
            catch(AddPhotoFailException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(this, "Zdjęcie dodane", "Gotowe", MessageBoxButtons.OK, MessageBoxIcon.None);
            BodyGalleryView bodygalleryform = new BodyGalleryView(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.ChangeForm(bodygalleryform);
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
                notetextBox.Text = "Wpisz tutaj notatkę";
                notetextboxclicked = false;
                notetextBox.Font = new Font(notetextBox.Font, FontStyle.Italic);

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BodyGalleryView bodygalleryform = new BodyGalleryView(start, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.ChangeForm(bodygalleryform);
        }
    }
}
