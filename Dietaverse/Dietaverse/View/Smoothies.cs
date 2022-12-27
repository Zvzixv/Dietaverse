using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Dietaverse.Database;
using Dietaverse.Model;

namespace Dietaverse.View
{
    public partial class Smoothies : Form
    {
        Form1 start;
        private GUI g = new GUI();

        List<SmoothiesIngr> smIngredients = new List<SmoothiesIngr>();
        List<SmoothiesIngr> smIngrChecked = new List<SmoothiesIngr>();
        List<SmoothiesRecipes> smRecipes = new List<SmoothiesRecipes> ();

        SmoothiesIngr si = new SmoothiesIngr();
        SmoothiesRecipes srecipes = new SmoothiesRecipes();
        public Smoothies(Form1 _start)
        {
            smRecipes = srecipes.MakeAList();
            start = _start;
            InitializeComponent();
            dynamicCheck();
            namelabel.Visible = false;
            cannotchooselabel.Text = "Wybór był zbyt trudny.";
            cannotchooselabel.Visible = false;
        }

        private void dynamicCheck()
        {
            flowLayoutPanel1.Controls.Clear();
            smIngredients = si.MakeAList();
            foreach (var item in smIngredients)
            {
                CheckBox chk = new CheckBox();
                chk.ForeColor = Color.Coral;
                chk.Width = 80;
                chk.Text = item.name.ToString();
                chk.CheckedChanged += new EventHandler(changeCheck);
                flowLayoutPanel1.Controls.Add(chk);
            }
        }

        private void changeCheck(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;

            if (chk.Checked)
            {
                foreach (var i in smIngredients)
                {
                    if (chk.Text == i.name)
                    {
                        smIngrChecked.Add(i);
                    }
                }
            }
            else if(!chk.Checked)
            {
                foreach (var i in smIngrChecked)
                {
                    if (chk.Text == i.name)
                    {
                        smIngrChecked.Remove(i);
                        return;
                    }
                }
            }
        }
        private SmoothiesRecipes generateSmoothieRecipe()
        {
            SmoothiesRecipes result = new SmoothiesRecipes();
            int maxconfidence = 0;

            foreach (var smoothie in smRecipes)
            {
                int confidence = 0;
                List<smoothies_ingr> ingrs = new List<smoothies_ingr>();
                foreach(var x in smoothie.ingredients)
                {
                    ingrs.Add(x);
                }
                foreach(var _checked in smIngrChecked)
                {
                    foreach(var contains in ingrs)
                    {
                        if(_checked.name == contains.name)
                            confidence++;
                    }
                }
                if (smoothie.sour == sourcheckBox.Checked)
                    confidence++;
                if (smoothie.sweet == sweetcheckBox.Checked)
                    confidence++;
                if (smoothie.fruity == fruitycheckBox.Checked)
                    confidence++;
                if (smoothie.vegetable == vegetablecheckBox.Checked)
                    confidence++;

                if (confidence > maxconfidence)
                {
                    result = smoothie;
                    result.name = smoothie.name;
                    maxconfidence = confidence;
                } 
            }
            if (maxconfidence == 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        private void addNewbutton1_Click(object sender, EventArgs e)
        {
            start.PnlFormLoader.Controls.Clear();
            AddNewSmoothie addnewsmoothieform = new AddNewSmoothie(start) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            start.ChangeForm(addnewsmoothieform);
        }

        private void Smoothiebutton1_Click(object sender, EventArgs e)
        {
            SmoothiesRecipes result = generateSmoothieRecipe();
            label.Visible = true;
            kcallabel.Visible = true;
            if (result == null)
            {
                smoothiepictureBox.Visible = false;
                label.Visible = false;
                cannotchooselabel.Visible = true;
                kcallabel.Visible=false;
                
            }
            else
            {
                label.Visible = true;
                cannotchooselabel.Visible = false;
                smoothiepictureBox.Visible = true;
                label.Text = result.name;
                kcallabel.Visible = true;
                kcallabel.Text = srecipes.CalculateKcal(result).ToString();

                photos photo = result.photos;

                byte[] tempBytes = Convert.FromBase64String(photo.data);
                MemoryStream memStr = new MemoryStream(tempBytes);
                Image photoImage = Image.FromStream(memStr);

                smoothiepictureBox.Image = g.ResizeImage(photoImage, smoothiepictureBox.Width, smoothiepictureBox.Height);
            }

        }

    }
}
