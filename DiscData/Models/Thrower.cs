using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscData.Models
{
    public class Thrower
    {
        public ThrowingType Throw { get; set; }
        public decimal Power { get; set; }
    }

    public enum ThrowingType
    {
        LHBH_RHFH,
        RHBH_LHFH
    }
}
