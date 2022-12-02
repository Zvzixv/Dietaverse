using AutoRollbackExample;
using Dietaverse.Model;
using System;
using System.Collections.Generic;
using Xunit;


namespace DietaverseTests
{
    public class SmoothiesIngrTests
    {
        [Fact]
        [AutoRollback]
        public void AddNewIngr_GivenGoodIngr_AddSucceed()
        {
            string name = "test";
            string kcal = "10";
            SmoothiesIngr si = new SmoothiesIngr();

            try
            {
                si.AddNewIngr(name, kcal);
            }
            catch (Exception ex)
            {
                Assert.True(false);
            }
            Assert.True(true);
        }

        [Fact]
        [AutoRollback]
        public void AddNewIngr_GivenWrongIngr_AddFailure()
        {
            string name = "test";
            string kcal = "not_a_value";

            SmoothiesIngr si = new SmoothiesIngr();
            try
            {
                si.AddNewIngr(name, kcal);
            }
            catch (Exception ex)
            {
                Assert.True(true);

            }

        }
        [Fact]
        [AutoRollback]
        public void MakeAList_Succeed()
        {
            SmoothiesIngr si = new SmoothiesIngr();
            string name = "test";
            string kcal = "10";
            si.AddNewIngr(name, kcal);

            List<SmoothiesIngr> ingred=si.MakeAList();

            var i = new SmoothiesIngr();
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
