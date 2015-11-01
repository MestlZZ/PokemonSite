using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Main.Models
{
    public class PokemonDbInitializer : DropCreateDatabaseIfModelChanges<PokemonContext>
    {
        protected override void Seed( PokemonContext db )
        {
            db.Pokemons.Add( new Pokemon
            {
                Name = "Студент",
                Damage = 8,
                Health = 90,
                SpellName = "Прогул",
                SpellDetails = "Позволяет в течении 3-х ходов избегать способностей вражеского покемона",
                SpellColdown = 5,
                BestPhrase = "А можно 5?"
            } );
            db.Pokemons.Add( new Pokemon
            {
                Name = "Пикачу",
                Damage = 10,
                Health = 100,
                SpellName = "Разряд молнии",
                SpellDetails = "Наносит 30 единиц урона врагу",
                SpellColdown = 4,
                BestPhrase = "Пика-пика"
            } );

            db.SaveChanges();
        }
    }
}