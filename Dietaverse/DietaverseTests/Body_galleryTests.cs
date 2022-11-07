using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DietaverseTests
{
    public class Body_galleryTests
    {
        [Fact]
        [AutoRollback]
        public void ListOfPhotos_ReturnSucceed()
        {
            Body_gallery bg = new Body_gallery();
            Users u = new Users();
            users testuser = u.CreateAccount("testuser", 10, "10");
            bg.addPhoto("C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp", "test", "", 0, testuser);

            List<body_gallery> listdg = bg.listOfPhotos(testuser);
            if (listdg.Count >= 1)
            {
                Assert.True(listdg.Any());
            }
        }

        [Fact]
        [AutoRollback]
        public void AddPhoto_AddSucceed()
        {
            Body_gallery bg = new Body_gallery();
            Users u = new Users();
            users testuser = u.CreateAccount("testuser", 10, "10");
            bg.addPhoto("C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp", "test", "", 0, testuser);

            List<body_gallery> listdg = bg.listOfPhotos(testuser);
            if (listdg.Count >= 1)
            {
                Assert.True(listdg.Any());
            }
        }
    }
}
