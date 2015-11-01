using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Main.Models
{
    public class Pokemon
    {
        // Id
        public int Id { get; set; }
        // Имя покемона
        public string Name { get; set; }
        // Здоровье покемона
        public int Health { get; set; }
        // урон покемона
        public int Damage { get; set; }
        // Имя способности
        public string SpellName { get; set; }
        // Описание способности
        public string SpellDetails { get; set; }
        // Время восстановления способности
        public int SpellColdown { get; set; }
        // Коронная фраза покемона
        public string BestPhrase { get; set; }
    }
}