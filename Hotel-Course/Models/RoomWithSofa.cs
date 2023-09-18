using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course.Models
{
    public class RoomWithSofa : DoubleRoom
    {
        public int NumberOfSofas { get; set; }

        public RoomWithSofa(string Id, string Description, float Cost, int AmountOfBeds, int NumberOfSofas): base(Id, Description, Cost, AmountOfBeds)
        {
            this.NumberOfSofas = NumberOfSofas;
        }
    }
}
