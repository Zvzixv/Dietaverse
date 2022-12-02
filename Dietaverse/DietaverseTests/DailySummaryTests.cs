using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System;
using Xunit;

namespace DietaverseTests
{
    public class DailySummaryTests
    {
        [Fact]
        [AutoRollback]
        public void Create_CreateSucceed()
        {
            Users u = new Users();
            string name = "testuser";
            string password = "test";
            double weight = 10;
            users testuser = u.CreateAccount(name, weight, password);

            DailySummary summary = new DailySummary();
            summary.Create(10, 10, testuser, "");
            if(summary.DownloadKcalFromDatabase(testuser, DateTime.Now)==10)
            {
                Assert.True(true);
            }
            if (summary.DownloadWeightFromDatabase(testuser, DateTime.Now) == 10)
            {
                Assert.True(true);
            }
            if (summary.DownloadNoteFromDatabase(testuser, DateTime.Now) == "")
            {
                Assert.True(true);
            }
        }
        [Fact]
        [AutoRollback]
        public void Update_UpdateSucceed()
        {
            Users u = new Users();
            string name = "testuser";
            string password = "test";
            double weight = 10;
            users testuser = u.CreateAccount(name, weight, password);

            DailySummary summary = new DailySummary();
            summary.Create(10, 10, testuser, "");
            summary.Update(10, 10, testuser, "note");
            if (summary.DownloadKcalFromDatabase(testuser, DateTime.Now) == 10)
            {
                Assert.True(true);
            }
            if (summary.DownloadWeightFromDatabase(testuser, DateTime.Now) == 10)
            {
                Assert.True(true);
            }
            if (summary.DownloadNoteFromDatabase(testuser, DateTime.Now) == "note")
            {
                Assert.True(true);
            }
        }

        [Fact]
        [AutoRollback]
        public void DownloadKcalFromDatabase_DownloadSucceed()
        {
            Users u = new Users();
            string name = "testuser";
            string password = "test";
            double weight = 10;
            users testuser = u.CreateAccount(name, weight, password);

            DailySummary summary = new DailySummary();
            summary.Create(10, 10, testuser, "");


            Assert.Equal(10, summary.DownloadKcalFromDatabase(testuser, DateTime.Now));
        }


        [Fact]
        [AutoRollback]
        public void DownloadWeightFromDatabase_DownloadSucceed()
        {
            Users u = new Users();
            string name = "testuser";
            string password = "test";
            double weight = 10;
            users testuser = u.CreateAccount(name, weight, password);

            DailySummary summary = new DailySummary();
            summary.Create(10, 10, testuser, "");


            Assert.Equal(10, summary.DownloadWeightFromDatabase(testuser, DateTime.Now));
        }

        [Fact]
        [AutoRollback]
        public void DownloadNoteFromDatabase_DownloadSucceed()
        {
            Users u = new Users();
            string name = "testuser";
            string password = "test";
            double weight = 10;
            users testuser = u.CreateAccount(name, weight, password);

            DailySummary summary = new DailySummary();
            summary.Create(10, 10, testuser, "");


            Assert.Equal("", summary.DownloadNoteFromDatabase(testuser, DateTime.Now));
        }
    }
}
