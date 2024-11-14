using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrism.AppliactionData
{
    internal class Tour
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Review> Reviews { get; set; }
        public decimal TicketCount { get; internal set; }
    }
}
