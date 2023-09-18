﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course.Models
{
    public class SingleRoom : Number
    {
        public int AmountOfBeds { get; set; }

        public SingleRoom(string Id, string Description, float Cost, int AmountOfBeds)
        {
            this.Id = Id;
            this.Description = Description;
            this.Cost = Cost;

            this.AmountOfBeds = AmountOfBeds;
        }
    }
}
