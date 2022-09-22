using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    internal class Recipes_ingredient
    {
        public int Id { get; set; }

        public virtual Smoothies_ingr smoothies_ingr { get; set; }
        public virtual Smoothies_recipes smoothies_recipes { get; set; }
    }
}
