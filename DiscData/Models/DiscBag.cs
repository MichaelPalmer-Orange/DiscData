using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscData.Models
{
    public class DiscBag
    {
        public Guid BagId { get; set; }
        public Guid PlayerId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Disc> Discs { get; set; }
    }
}
