using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dietaverse.Database;
using Dietaverse.Model;
using Dietaverse.View;

namespace Dietaverse.View
{
    public partial class Smoothies : Form
    {
        Form1 start;
        private GUI g = new GUI();

        List<Smoothies_ingr> smIngredients = new List<Smoothies_ingr>();
        List<Smoothies_ingr> smIngrChecked = new List<Smoothies_ingr>();
        List<Smoothies_recipes> smRecipes = new List<Smoothies_recipes> ();

        Smoothies_ingr si = new Smoothies_ingr();
        Smoothies_recipes srecipes = new Smoothies_recipes();
        public Smoothies(Form1 _start)
        {
            smRecipes = srecipes.makeAList();
            start = _start;
            InitializeComponent();
            dynamiccheck();
            namelabel.Visible = false;
            cannotchooselabel.Text = "It was too hard choice";
            cannotchooselabel.Visible = false;
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
        private Smoothies_recipes algorithm()
        {
            Smoothies_recipes result = new Smoothies_recipes();
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
                //else
                //    confidence = 0;           //jeżeli ktos ma ochotę na to i na to to niech się nie zeruje

                if (smoothie.sweet == sweetcheckBox.Checked)
                    confidence++;
                //else
                //    confidence = 0;

                if (smoothie.fruity == fruitycheckBox.Checked)
                    confidence++;
                //else
                //    confidence = 0;

                if (smoothie.vegetable == vegetablecheckBox.Checked)
                    confidence++;
                //else
                //    confidence = 0;

                //chyba, ze ktos nie ma ochoty, to niech się zeruje
                //nie działa, bo jak ktos chce albo słodki albo kwaśny a smoothie jest tylko kwaśne to się zeruje
                //if (smoothie.sour != sourcheckBox.Checked)
                //    confidence = 0;
                //if (smoothie.sweet != sweetcheckBox.Checked)
                //    confidence = 0;
                //if (smoothie.fruity != fruitycheckBox.Checked)
                //    confidence=0;
                //if (smoothie.vegetable != vegetablecheckBox.Checked)
                //    confidence=0;



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
            start.changeForm(addnewsmoothieform);
        }

        private void Smoothiebutton1_Click(object sender, EventArgs e)
        {
            Smoothies_recipes result = algorithm();
            namelabel.Visible = true;
            if (result == null)
            {
                smoothiepictureBox.Visible = false;
                namelabel.Visible = false;
                cannotchooselabel.Visible = true;
                
            }
            else
            {
                namelabel.Visible = true;
                cannotchooselabel.Visible = false;
                smoothiepictureBox.Visible = true;
                namelabel.Text = result.name;

                System.IO.DirectoryInfo filepathtemp = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString());
                string filepath = filepathtemp.ToString() + @"\Resources\";
                Image photoImage = Image.FromFile(filepath + result.photo);

                smoothiepictureBox.Image = g.ResizeImage(photoImage, smoothiepictureBox.Width, smoothiepictureBox.Height);
            }

        }

        private void Smoothies_Load(object sender, EventArgs e)
        {

        }
    }
}
