using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course.Models
{
    public class Luxe : Number
    {
        public int AmountOfBathrooms { get; set; }

        public Luxe(string Id, string Description, float Cost, int AmountOfBathrooms) 
        {
            this.Id = Id;
            this.Description = Description;
            this.Cost = Cost;

            this.AmountOfBathrooms = AmountOfBathrooms;
        }
    }
}
