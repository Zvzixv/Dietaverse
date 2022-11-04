using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;


namespace DietaverseTests
{
    public class Smoothies_ingrTests
    {
        [Fact]
        [AutoRollback]
        public void addNewIngr_GivenGoodIngr_AddSucceed()
        {
            string name = "test";
            string kcal = "10";
            Smoothies_ingr si = new Smoothies_ingr();

            try
            {
                si.addNewIngr(name, kcal);
            }
            catch (Exception ex)
            {
                Assert.True(false);
            }
            Assert.True(true);
        }

        [Fact]
        [AutoRollback]
        public void addNewIngr_GivenWrongIngr_AddFailure()
        {
            string name = "test";
            string kcal = "not_a_value";

            Smoothies_ingr si = new Smoothies_ingr();
            try
            {
                si.addNewIngr(name, kcal);
            }
            catch (Exception ex)
            {
                Assert.True(true);

            }

        }
        [Fact]
        [AutoRollback]
        public void makeAList_Succeed()
        {
            Smoothies_ingr si = new Smoothies_ingr();
            string name = "test";
            string kcal = "10";
            si.addNewIngr(name, kcal);

            List<Smoothies_ingr> ingred=si.makeAList();

            var i = new Smoothies_ingr();
            foreach(var x in ingred)
            {
                if (x.name == name)
                    i = x;
            }

            Assert.Equal(name, i.name);
            Assert.Equal(Double.Parse(kcal), i.kcal);


        }


    }
}
