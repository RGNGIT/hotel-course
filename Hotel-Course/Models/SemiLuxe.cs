using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course.Models
{
    public class SemiLuxe : Number
    {
        public string SemiLuxeAddings { get; set; }

        public SemiLuxe(string Id, string Description, float Cost, string SemiLuxeAddings)
        {
            this.Id = Id;
            this.Description = Description;
            this.Cost = Cost;

            this.SemiLuxeAddings = SemiLuxeAddings;
        }
    }
}
