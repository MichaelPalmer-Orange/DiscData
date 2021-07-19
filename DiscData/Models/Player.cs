using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscData.Models
{
    public class Player
    {
        public Guid PlayerId { get; set; }
        public string Name { get; set; }
        public ThrowingType DefaultThrow { get; set; }
    }
}
