using Lannister_Spyduh.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lannister_Spyduh.DataAccess
{
    public class SpyRepository
    {
        private static List<Spy> _spies = new List<Spy>()
        {
            new Spy()
            {
                CodeName = "GooseGoon Purcell",
                faction = Faction.Blue,
                Id = 1,
                skillType = SkillType.Espionage,
                service = Service.Babysitting,
            },
            new Spy()
            {
                CodeName = "Nissa Night",
                faction = Faction.Blue,
                Id = 2,
                skillType = SkillType.MartialArts,
                service = Service.Bodyguard,
            },
            new Spy()
            {
                CodeName = "Moonlight Baylor",
                faction = Faction.Blue,
                Id = 3,
                skillType = SkillType.Tracking,
                service = Service.Weddings,
            },
            new Spy()
            {
                CodeName = "Jigsawret",
                faction = Faction.Red,
                Id = 4,
                skillType = SkillType.Demolitions,
                service = Service.Babysitting,
            },
            new Spy()
            {
                CodeName = "Bristopher",
                faction = Faction.Red,
                Id = 5,
                skillType = SkillType.Hacking,
                service = Service.ArtHeist,
            }
        };

        internal IEnumerable<Spy> GetTeamSpies(Faction spyFaction)
        {
            var teamSpies = _spies.Where(spy => spy.faction == spyFaction);

            return teamSpies;
        }

    }
}

