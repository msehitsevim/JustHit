using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JustHit.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public int Health { get; set; } 

        public int Armor { get; set; }

        public int Damage { get; set; }

        public int SpellDamage { get; set; }
    }
}
