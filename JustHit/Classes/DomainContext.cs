using JustHit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustHit.Classes
{
    public class DomainContext : DbContext
    {
        public IConfiguration Configuration { get; }
      
        public DomainContext() : base()
        {

        }



        public DomainContext(DbContextOptions<DomainContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        //entities
        public DbSet<Player> Player { get; set; }
        public DbSet<FightInfo> FightInfo { get; set; }
        public DbSet<BotProfile> BotProfile { get; set; }
        
    }
}
