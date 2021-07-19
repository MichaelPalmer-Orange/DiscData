using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscData.Models
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Disc> Discs { get; set; }
        public IEnumerable<string> Aliases { get; set; }
    }
}
