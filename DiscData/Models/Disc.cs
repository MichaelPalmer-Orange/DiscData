using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscData.Models
{
    public class Disc
    {
        public Guid DiscId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public decimal HighSpeedTurn { get; set; }
        public decimal LowSpeedFade { get; set; }
        public int MaxWeight { get; set; }
        public int Range { get; set; }
        public DiscType Type { get; set; }
        public decimal[] FlightPath { get; set; }
        public Tuple<int, int> MatrixLocation { get; set; }
    }

    public enum DiscType
    {
        DistanceDriver,
        FairwayDriver,
        MidRange,
        PuttAndApproach
    }
}