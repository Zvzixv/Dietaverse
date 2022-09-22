using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dietaverse.Model;
using Dietaverse.View;

namespace Dietaverse.View
{
    public partial class Smoothies : Form
    {
        Form1 start;

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
        }

        private void dynamiccheck()
        {
            flowLayoutPanel1.Controls.Clear();
            //smIngredients.Clear();
            smIngredients = si.makeAList();
            foreach (var item in smIngredients)
            {
                CheckBox chk = new CheckBox();
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
            algorithm();
        }
    }
}
