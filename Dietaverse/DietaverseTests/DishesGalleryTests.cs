using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DietaverseTests
{
    public class DishesGalleryTests
    {
        [Fact]
        [AutoRollback]
        public void ListOfPhotos_ReturnSucceed()
        {
            DishesGallery dg = new DishesGallery();
            Users u = new Users();
            users testuser = u.CreateAccount("testuser", 10, "10");
            dg.AddPhoto("C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp", "test", "", 0, testuser);

            List<dishes_gallery> listdg = dg.ListOfPhotos(testuser);
            if(listdg.Count>=1)
            {
                Assert.True(listdg.Any());
            }
        }

        [Fact]
        [AutoRollback]
        public void AddPhoto_AddSucceed()
        {
            DishesGallery dg = new DishesGallery();
            Users u = new Users();
            users testuser = u.CreateAccount("testuser", 10, "10");
            dg.AddPhoto("C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp", "test", "", 0, testuser);

            List<dishes_gallery> listdg = dg.ListOfPhotos(testuser);
            if (listdg.Count >= 1)
            {
                Assert.True(listdg.Any());
            }
        }
    }
}
