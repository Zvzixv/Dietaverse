using Dietaverse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietaverse.Model
{
    public class Daily_summary
    {
        public int Id { get; set; }
        public string kcal_amount { get; set; }
        public double weight { get; set; }
        public string notes { get; set; }

        public virtual users users { get; set; }
        public virtual months months { get; set; }


        public Daily_summary() { }
    }
}
