using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Main.Models;

namespace Main.Controllers
{
    public class HomeController : Controller
    {
        PokemonContext db = new PokemonContext();
        public ActionResult Index()
        {
            ViewBag.Pokemons = db.Pokemons;
            return View();
        }
        [HttpGet]
        public ActionResult Create( )
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( Pokemon pokemon )
        {
            db.Pokemons.Add( pokemon );
            db.SaveChanges();
            return Index();
        }
        public ActionResult Details( int id )
        {
            foreach (var b in db.Pokemons)
                if (b.Id == id)
                {
                    ViewBag.Pokemon = b;
                    break;
                }
            return View();
        }
        [HttpGet]
        public ActionResult Edit( int id )
        {
            ViewBag.PokemonsId = id;
            foreach (var b in db.Pokemons)
                if (b.Id == id)
                {
                    ViewBag.Pokemon = b;
                    break;
                }
            return View();
        }
        [HttpPost]
        public RedirectResult Edit( Pokemon pokemon )
        {
            foreach (var b in db.Pokemons)
                if (b.Id == pokemon.Id)
                {
                    if(pokemon.Name != null)
                        b.Name = pokemon.Name;
                    if (pokemon.Damage != 0)
                        b.Damage = pokemon.Damage;
                    if (pokemon.Health != 0)
                        b.Health = pokemon.Health;
                    if (pokemon.SpellName != null)
                        b.SpellName = pokemon.SpellName;
                    if (pokemon.SpellDetails != null)
                        b.SpellDetails = pokemon.SpellDetails;
                    if (pokemon.SpellColdown != 0)
                        b.SpellColdown = pokemon.SpellColdown;
                    if (pokemon.BestPhrase != null)
                        b.BestPhrase = pokemon.BestPhrase;
                    break;
                }
            db.SaveChanges();
            return RedirectPermanent( "/Home/Index" );
        }

        protected override void Dispose( bool disposing )
        {
            db.Dispose();
            base.Dispose( disposing );
        }
    }
}