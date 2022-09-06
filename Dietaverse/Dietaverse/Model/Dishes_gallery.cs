using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    public class Dishes_gallery
    {
        public Dishes_gallery()
        {
            this.users = new HashSet<users>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string recipe { get; set; }
        public int kcal { get; set; }
        public string photo { get; set; }

        public virtual ICollection<users> users { get; set; }
    }
}
