using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Pokedex
{
    class Program
    {
        public string PokemonPrint()
        {

            using(var db = new PokedexContext())
            {
                var query =
                    from p in db.Pokemon
                    select p;

                //return $"{pokedata.PName}";
                foreach(var pokemons in query)
                {
                    return $"{pokemons.Pname}";
                }
            }
            return "";

           
        }
    }
}
