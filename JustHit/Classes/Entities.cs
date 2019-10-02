using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JustHit.Classes
{
    [Table("Player")]
    public class Player : IDisposable
    {
        [Key]
        public int Id { get; set; }
        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }

        public int Damage { get; set; }

        public int SpellDamage { get; set; }

        public void Dispose()
        {
           
        }
    }
    [Table("FightInfo")]
    public class FightInfo
    {
      
        public int Id { get; set; }

        public int UserHealth { get; set; }

        public int BotHealth { get; set; }

        public int Turn { get; set; }

        public int UserDamage { get; set; }

        public int BotDamage { get; set; }
    }
    [Table("BotProfile")]
    public class BotProfile : IDisposable
    {
       [Key]
        public int Id { get; set; }
        public int BotId { get; set; }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }

        public int Damage { get; set; }

        public int SpellDamage { get; set; }

        public void Dispose()
        {
      
        }
    }
}
