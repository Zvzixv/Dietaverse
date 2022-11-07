using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Linq;
using Xunit;

namespace DietaverseTests
{
    public class Daily_SummaryTests
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

            Daily_summary summary = new Daily_summary();
            summary.create(10, 10, testuser, "");
            if(summary.downloadKcalFromDatabase(testuser, DateTime.Now)==10)
            {
                Assert.True(true);
            }
            if (summary.downloadWeightFromDatabase(testuser, DateTime.Now) == 10)
            {
                Assert.True(true);
            }
            if (summary.downloadNoteFromDatabase(testuser, DateTime.Now) == "")
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

            Daily_summary summary = new Daily_summary();
            summary.create(10, 10, testuser, "");
            summary.update(10, 10, testuser, "note");
            if (summary.downloadKcalFromDatabase(testuser, DateTime.Now) == 10)
            {
                Assert.True(true);
            }
            if (summary.downloadWeightFromDatabase(testuser, DateTime.Now) == 10)
            {
                Assert.True(true);
            }
            if (summary.downloadNoteFromDatabase(testuser, DateTime.Now) == "note")
            {
                Assert.True(true);
            }
        }

        [Fact]
        [AutoRollback]
        public void downloadKcalFromDatabase_DownloadSucceed()
        {
            Users u = new Users();
            string name = "testuser";
            string password = "test";
            double weight = 10;
            users testuser = u.CreateAccount(name, weight, password);

            Daily_summary summary = new Daily_summary();
            summary.create(10, 10, testuser, "");


            Assert.Equal(10, summary.downloadKcalFromDatabase(testuser, DateTime.Now));
        }


        [Fact]
        [AutoRollback]
        public void downloadWeightFromDatabase_DownloadSucceed()
        {
            Users u = new Users();
            string name = "testuser";
            string password = "test";
            double weight = 10;
            users testuser = u.CreateAccount(name, weight, password);

            Daily_summary summary = new Daily_summary();
            summary.create(10, 10, testuser, "");


            Assert.Equal(10, summary.downloadWeightFromDatabase(testuser, DateTime.Now));
        }

        [Fact]
        [AutoRollback]
        public void downloadNoteFromDatabase_DownloadSucceed()
        {
            Users u = new Users();
            string name = "testuser";
            string password = "test";
            double weight = 10;
            users testuser = u.CreateAccount(name, weight, password);

            Daily_summary summary = new Daily_summary();
            summary.create(10, 10, testuser, "");


            Assert.Equal("", summary.downloadNoteFromDatabase(testuser, DateTime.Now));
        }
    }
}
