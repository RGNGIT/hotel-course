using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course.Models
{
    public abstract class Request
    {
        public string? Id { get; set; }
        public string? Holder { get; set; }
        public DateTime? dateFrom { get; set; }
        public DateTime? dateTo { get; set; }
    }
}
