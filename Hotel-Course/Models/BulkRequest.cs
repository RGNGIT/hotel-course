using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Course.Models
{
    public class BulkRequest : Request
    {
        public List<Number> Numbers { get; set; }
        public List<int>? DiscountMap { get; set; }

        public BulkRequest(string Id, string Holder, List<Number> numbers, DateTime dateFrom, DateTime dateTo) 
        {
            this.Id = Id;
            this.Holder = Holder;
            this.Numbers = numbers;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
        }
    }
}
