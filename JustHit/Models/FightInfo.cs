using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JustHit.Models
{
    public class FightInfo
    {
        [Key]
        public int Id { get; set; }

        public int UserHealth { get; set; }

        public int BotHealth { get; set; }

        public int Turn { get; set; }

        public int UserDamage { get; set; }

        public int BotDamage { get; set; }
    }
}
