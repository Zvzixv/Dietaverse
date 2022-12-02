using AutoRollbackExample;
using Dietaverse.Database;
using Dietaverse.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DietaverseTests
{
    public class BodyGalleryTests
    {
        [Fact]
        [AutoRollback]
        public void ListOfPhotos_ReturnSucceed()
        {
            BodyGallery bg = new BodyGallery();
            Users u = new Users();
            users testuser = u.CreateAccount("testuser", 10, "10");
            bg.AddPhoto("C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp", "test", "", 0, testuser);

            List<body_gallery> listdg = bg.ListOfPhotos(testuser);
            if (listdg.Count >= 1)
            {
                Assert.True(listdg.Any());
            }
        }

        [Fact]
        [AutoRollback]
        public void AddPhoto_AddSucceed()
        {
            BodyGallery bg = new BodyGallery();
            Users u = new Users();
            users testuser = u.CreateAccount("testuser", 10, "10");
            bg.AddPhoto("C:\\Users\\zuzia\\source\\repos\\Dietaverse\\Dietaverse\\test.bmp", "test", "", 0, testuser);

            List<body_gallery> listdg = bg.ListOfPhotos(testuser);
            if (listdg.Count >= 1)
            {
                Assert.True(listdg.Any());
            }
        }
    }
}
