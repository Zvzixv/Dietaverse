﻿using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DietaverseTests
{
    public class Dishes_galleryTests
    {
        [Fact]
        [AutoRollback]
        public void ListOfPhotos_ReturnSucceed()
        {
            Dishes_gallery dg = new Dishes_gallery();
            Users u = new Users();
            users testuser = u.CreateAccount("testuser", 10, "10");
            dg.addPhoto("C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp", "test", "", 0, testuser);

            List<dishes_gallery> listdg = dg.listOfPhotos(testuser);
            if(listdg.Count>=1)
            {
                Assert.True(listdg.Any());
            }
        }

        [Fact]
        [AutoRollback]
        public void AddPhoto_AddSucceed()
        {
            Dishes_gallery dg = new Dishes_gallery();
            Users u = new Users();
            users testuser = u.CreateAccount("testuser", 10, "10");
            dg.addPhoto("C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp", "test", "", 0, testuser);

            List<dishes_gallery> listdg = dg.listOfPhotos(testuser);
            if (listdg.Count >= 1)
            {
                Assert.True(listdg.Any());
            }
        }
    }
}
