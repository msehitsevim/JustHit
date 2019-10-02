using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JustHit.Models;
using JustHit.Classes;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;

namespace JustHit.Controllers
{
    public class HomeController : Controller
    {
        private readonly DomainContext _domainContext;
        private static IHostingEnvironment _hostingEnvironment;
        public IMapper _mapper { get; set; }

        public HomeController(DomainContext domainContext, IHostingEnvironment hostingEnvironment, IMapper mapper)
        {
            _domainContext = domainContext;
            _hostingEnvironment = hostingEnvironment;
            _mapper = mapper;
        }

        public IActionResult Index() {

            IndexModel indexModel = new IndexModel();
            //var bp = _domainContext.BotProfile.Select(p => new  Models.BotProfile() { BotId = p.Id, Name = p.Name, Armor = p.Armor, Damage=p.Damage, Health=p.Health , SpellDamage= p.SpellDamage, Id =p.Id}).ToList();
            var bp = _domainContext.BotProfile.Select(p => new  Models.BotProfile() { BotId = p.Id, Name = p.Name, Armor = p.Armor, Damage=p.Damage, Health=p.Health , SpellDamage= p.SpellDamage, Id =p.Id}).OrderByDescending(a => a.Id).FirstOrDefault();

            var pp = _domainContext.Player.Select(p => new Models.Player() { PlayerId = p.Id, PlayerName = p.PlayerName, Armor = p.Armor, Damage = p.Damage, Health = p.Health, SpellDamage = p.SpellDamage, Id = p.Id }).OrderByDescending(a=>a.Id).FirstOrDefault();
            indexModel.IndexBotProfile = bp;
            indexModel.IndexProfile = pp;
         
            Models.Player player = new Models.Player();
            player.PlayerId = indexModel.IndexProfile.PlayerId;
            player.PlayerName = indexModel.IndexProfile.PlayerName;
            player.Health = indexModel.IndexProfile.Health;
            player.SpellDamage = indexModel.IndexProfile.SpellDamage;
            player.Armor = indexModel.IndexProfile.Armor;
            player.Damage = indexModel.IndexProfile.Damage;

            Models.BotProfile botProfile = new Models.BotProfile();
            botProfile.BotId = indexModel.IndexBotProfile.BotId;
            botProfile.Armor = indexModel.IndexBotProfile.Armor;
            botProfile.Damage = indexModel.IndexBotProfile.Damage;
            botProfile.SpellDamage = indexModel.IndexBotProfile.SpellDamage;
            botProfile.Name = indexModel.IndexBotProfile.Name;
            botProfile.Health = indexModel.IndexBotProfile.Health;

            return View(indexModel);
        }


 
     




        #region delete
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}


//Classes.BotProfile BotAddModel = new Classes.BotProfile();
//Random rnd = new Random();
//BotAddModel.Name = "bot" + rnd.Next(1,10000);
//BotAddModel.Damage = rnd.Next(1, 10);
//BotAddModel.Armor = rnd.Next(1,50);
//BotAddModel.SpellDamage = rnd.Next(1, 30);

//Classes.Player PlayerAddModel = new Classes.Player();
//PlayerAddModel.PlayerName = "player" + rnd.Next(1,1000);
//PlayerAddModel.Damage = rnd.Next(1, 10);
//PlayerAddModel.Armor = rnd.Next(1,50);
//PlayerAddModel.SpellDamage = rnd.Next(1,30);
