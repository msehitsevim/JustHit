using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustHit.Classes
{
    public class JustHitMapper : AutoMapper.Profile
    {
        public JustHitMapper()
        {
            CreateMap<Classes.Player, JustHit.Models.Player>();
            CreateMap<JustHit.Models.Player, Classes.Player>();
            
            CreateMap<Classes.BotProfile, JustHit.Models.BotProfile>();
            CreateMap<JustHit.Models.BotProfile, Classes.BotProfile>();

        }
    }
}
