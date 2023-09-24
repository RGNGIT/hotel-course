using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course.Models
{
    public class InstantRequest : Request
    {
        public Number Number { get; set; }
        public int discountApplied { get; set; } = 0;

        public InstantRequest(string Id, string Holder, Number number, DateTime dateFrom, DateTime dateTo) 
        {
            this.Id = Id;
            this.Number = number;
            this.Holder = Holder;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
        }
    }
}
