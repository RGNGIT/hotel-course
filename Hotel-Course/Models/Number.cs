using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course.Models
{
    public abstract class Number
    {
        public string? Id { get; set; }
        public string? Description { get; set; }
        public float Cost { get; set; }
        public bool Taken { get; set; } = false;
    }
}
