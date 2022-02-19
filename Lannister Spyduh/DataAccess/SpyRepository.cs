using Lannister_Spyduh.Models;
using System.Collections.Generic;

namespace Lannister_Spyduh.DataAccess
{
    public class SpyRepository
    {
        private static List<Spy> _spies = new List<Spy>()
        {
            new Spy()
            {
                CodeName = "GooseGoon Purcell",
                Faction = Faction.Blue,
                Id = 1,
                Skills = new List<SkillType>()
                {
                 SkillType.Espionage,
                 SkillType.Demolitions,
                },
                Services = new List<ServiceOffered>()
                {
                ServiceOffered.Babysitting,
                }
            },
            new Spy()
            {
                CodeName = "Nissa Night",
                Faction = Faction.Blue,
                Id = 2,
                Skills = new List<SkillType>()
                { 
                    SkillType.MartialArts,
                },
                Services = new List<ServiceOffered>()
                {
                ServiceOffered.Bodyguard,
                },
            },
            new Spy()
            {
                CodeName = "Moonlight Baylor",
                Faction = Faction.Blue,
                Id = 3,
                Skills = new List<SkillType>()
                {
                SkillType.Tracking,
                },
                Services = new List<ServiceOffered>()
                {
                ServiceOffered.Weddings,
                },
            },
            new Spy()
            {
                CodeName = "Jigsawret",
                Faction = Faction.Red,
                Id = 4,
                Skills = new List<SkillType>()
                {
                SkillType.Demolitions,
                },
                Services = new List<ServiceOffered>()
                {
                ServiceOffered.Babysitting,
                },
            },
            new Spy()
            {
                CodeName = "Bristopher",
                Faction = Faction.Red,
                Id = 5,
                Skills = new List<SkillType>()
                {
                SkillType.Hacking,
                },
                Services = new List<ServiceOffered>()
                {
                ServiceOffered.ArtHeist,
                },
            }
        };

        internal IEnumerable<Spy> GetSpysBySkills(Skills skills)
        {

        }

        //internal List<Spy> GetAll()
        //{
        //    return _spy;
        //}
    }
}

