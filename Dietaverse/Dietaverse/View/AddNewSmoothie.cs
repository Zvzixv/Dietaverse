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
    public partial class AddNewSmoothie : Form
    {
        Form1 start;
        Smoothies_ingr si = new Smoothies_ingr();

        string path;
        Image i;
        GUI g = new GUI();

        string ingrName;
        string ingrKcal;

        string smName;
        string smPhoto;
        string smKcal;
        bool smIsFruity;
        bool smIsVegetable;
        bool smIsSweet;
        bool smIsSour;
        List<Smoothies_ingr> smIngredients = new List<Smoothies_ingr>();
        List<Smoothies_ingr> smIngrChecked = new List<Smoothies_ingr>();
        public AddNewSmoothie(Form1 _start)
        {
            start = _start;

            InitializeComponent();
            dynamiccheck();
        }

        private void dynamiccheck()
        {
            flowLayoutPanel1.Controls.Clear();
            //smIngredients.Clear();
            smIngredients = si.makeAList();
            foreach (var item in smIngredients)
            {
                CheckBox chk = new CheckBox();
                chk.ForeColor = Color.Coral;
                chk.Width = 80;
                chk.Text = item.name.ToString();
                chk.CheckedChanged += new EventHandler(changecheck);
                flowLayoutPanel1.Controls.Add(chk);
            }
        }

        private void changecheck(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;

            if(chk.Checked)
            {
                foreach(var i in smIngredients)
                {
                    if(chk.Text == i.name)
                    {
                        smIngrChecked.Add(i);
                    }
                }
            }
        }

        private void addNewIngrbutton1_Click(object sender, EventArgs e)
        {
            ingrName = nametextBox.Text;
            ingrKcal = kcaltextBox.Text;

            try
            {
                si.addNewIngr(ingrName, ingrKcal);
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong values!");
            }

            dynamiccheck();
        }

        private void AddNewSmoothiebutton_Click(object sender, EventArgs e)
        {


            smName = smnametextBox.Text;
            //smKcal = kcaltextBox.Text;
            smPhoto = path;
            smIsFruity = fruitycheckBox.Checked;
            smIsSour = sourcheckBox.Checked;
            smIsSweet = sweetcheckBox.Checked;
            smIsVegetable = vegetablecheckBox.Checked;

            Smoothies_recipes sr = new Smoothies_recipes();
            try
            {
                sr.addNewSmoothie(smName, smPhoto, smIngrChecked, smIsFruity, smIsVegetable, smIsSweet, smIsSour);
            }
            catch (AddPhotoFailException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Added successfully");

        }

        private void choosePhotobutton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                i = Image.FromFile(path);
                photolabel.Visible = false;
                pictureBox1.Image = g.ResizeImage(i, pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            start.PnlFormLoader.Controls.Clear();
            Smoothies smoothiesform = new Smoothies(start) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.changeForm(smoothiesform);
        }
    }
}
