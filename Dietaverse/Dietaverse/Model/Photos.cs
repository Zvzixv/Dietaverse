using Dietaverse.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{

        public partial class Photos
        {
            public int Id { get; set; }
            public string filename { get; set; }
            public string data { get; set; }

            public virtual body_gallery body_gallery { get; set; }
            public virtual dishes_gallery dishes_gallery { get; set; }
            public virtual smoothies_recipes smoothies_recipes { get; set; }


            public photos FindPhoto(int id)
            {
                using (var db = new db_modelContainer())
                {
                    return db.photosSet.Single(a => a.Id == id);
                }
        }
    }
}
