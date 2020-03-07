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
        public string Hp { get; set; }
        public string Attack { get; set; }
        public string Defense { get; set; }
        public string SpAttack { get; set; }
        public string SpDefense { get; set; }
        public string Speed { get; set; }

        public virtual ICollection<Pokemon> Pokemon { get; set; }
    }
}
