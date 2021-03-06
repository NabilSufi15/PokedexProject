﻿using System;
using System.Collections.Generic;

namespace Pokedex
{
    public partial class Pokemon
    {
        public int PokemonId { get; set; }
        public string Pname { get; set; }
        public string Ptype { get; set; }
        public string Pdescription { get; set; }
        public string Pheight { get; set; }
        public string Pweight { get; set; }
        public string Pimage { get; set; }
        public string Pcry { get; set; }
        public string Psound { get; set; }
        public int? StatsId { get; set; }

        public virtual Stats Stats { get; set; }

        public override string ToString()
        {
            return $"{PokemonId} {Pname} {Ptype}";
        }
    }
}
