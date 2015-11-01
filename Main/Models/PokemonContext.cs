using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Main.Models
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}