using System;
using System.Collections.Generic;

namespace Pokedex
{
    public partial class Stats
    {
        public Stats()
        {
            Pokemon = new HashSet<Pokemon>();
        }

        public int StatsId { get; set; }
        public int? Hp { get; set; }
        public int? Attack { get; set; }
        public int? Defence { get; set; }
        public int? SpAttack { get; set; }
        public int? SpDefense { get; set; }
        public int? Speed { get; set; }

        public virtual ICollection<Pokemon> Pokemon { get; set; }
    }
}
