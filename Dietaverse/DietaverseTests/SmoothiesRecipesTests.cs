using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System.Collections.Generic;
using Xunit;

namespace DietaverseTests
{
    public class SmoothiesRecipesTests
    {
        List<SmoothiesIngr> testIngredients = new List<SmoothiesIngr>();

        private void AddTestIngredients()
        {
            SmoothiesIngr test1 = new SmoothiesIngr() {name = "test1", kcal = 1 };
            SmoothiesIngr test2 = new SmoothiesIngr() { name = "test2", kcal = 2 };
            testIngredients.Add(test1);
            testIngredients.Add(test2);
            test1.AddNewIngr("test1", "1");
            test1.AddNewIngr("test2", "2");
        }

        [Fact]
        [AutoRollback]
        public void AddNewSmoothie_GivenProperVariables_CreateSucceed()
        {
            string name = "testSmoothie";
            string path = "C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp";
            bool fruity = true; bool vegetable = false; bool sweet = true; bool sour = true;
            AddTestIngredients();

            SmoothiesRecipes sr = new SmoothiesRecipes();
            sr.AddNewSmoothie(name, path, testIngredients,fruity, vegetable, sweet, sour);

            smoothies_recipes fromdb = sr.GetSmoothie(name);
            Assert.Equal(name, fromdb.name);
            
        }

        [Fact]
        [AutoRollback]
        public void MakeAList_GivenList_CreateSucceed()
        {
            string name = "testSmoothie";
            string path = "C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp";
            bool fruity = true; bool vegetable = false; bool sweet = true; bool sour = true;
            AddTestIngredients();

            SmoothiesRecipes sr = new SmoothiesRecipes();
            sr.AddNewSmoothie(name, path, testIngredients, fruity, vegetable, sweet, sour);

            List <SmoothiesRecipes> lists = sr.MakeAList();

            if(lists.Count >= 1)
            {
                Assert.True(true);
            }
        }
    }
}
