using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DietaverseTests
{
    public class Smoothies_recipesTests
    {
        List<Smoothies_ingr> testIngredients = new List<Smoothies_ingr>();

        private void addTestIngredients()
        {
            Smoothies_ingr test1 = new Smoothies_ingr() {name = "test1", kcal = 1 };
            Smoothies_ingr test2 = new Smoothies_ingr() { name = "test2", kcal = 2 };
            testIngredients.Add(test1);
            testIngredients.Add(test2);
            test1.addNewIngr("test1", "1");
            test1.addNewIngr("test2", "2");
        }

        [Fact]
        [AutoRollback]
        public void addNewSmoothie_GivenProperVariables_CreateSucceed()
        {
            string name = "testSmoothie";
            string path = "C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp";
            bool fruity = true; bool vegetable = false; bool sweet = true; bool sour = true;
            addTestIngredients();

            Smoothies_recipes sr = new Smoothies_recipes();
            sr.addNewSmoothie(name, path, testIngredients,fruity, vegetable, sweet, sour);

            smoothies_recipes fromdb = sr.getSmoothie(name);
            Assert.Equal(name, fromdb.name);
            
        }

        public void makeAList_GivenList_CreateSucceed()
        {

        }

        public void makeAList_GivenEmptyList_EmptyListReturned()
        {

        }
    }
}
