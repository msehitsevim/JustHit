using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JustHit.Classes;
using Microsoft.AspNetCore.Mvc;

namespace JustHit.Controllers
{
    public class LoginController : Controller
    {
        private readonly DomainContext _domainContext;
        public LoginController(DomainContext domainContext)
        {
            _domainContext = domainContext;
        }
        public IActionResult Index()
        {
        
            return View();
        }

        [HttpPost]
        public IActionResult AddRecord(string PlayerName) {
            if (ModelState.IsValid)
            {
                //var temp = _domainContext.Player.Select(p => p.PlayerName).FirstOrDefault();
                using (BotProfile NewBotRecord = new BotProfile())
                {
                    Random rnd = new Random();
                    NewBotRecord.BotId = rnd.Next(1, 10000);
                    NewBotRecord.Name = "bot" + NewBotRecord.BotId;
                    NewBotRecord.Health = 100;
                    NewBotRecord.Damage = rnd.Next(5, 10);
                    NewBotRecord.Armor = rnd.Next(1, 50);
                    NewBotRecord.SpellDamage = rnd.Next(15, 30);
                    _domainContext.BotProfile.Add(NewBotRecord);
                }
               

                using (Player NewUserRecord = new Player())
                {
                    Random rnd = new Random();
                    NewUserRecord.PlayerId = rnd.Next(1, 10000);
                    NewUserRecord.PlayerName = PlayerName;
                    NewUserRecord.Health = 100;
                    NewUserRecord.Damage = rnd.Next(5, 10);
                    NewUserRecord.Armor = rnd.Next(1, 50);
                    NewUserRecord.SpellDamage = rnd.Next(15, 30);
                    _domainContext.Player.Add(NewUserRecord);
                }

                _domainContext.SaveChanges();
            }
            return RedirectToAction("Index","Home");
        }
        


    }
}
