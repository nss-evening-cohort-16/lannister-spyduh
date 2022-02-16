using System.Collections.Generic;

namespace Lannister_Spyduh.Models
{
    public class Spy
    {
        public string CodeName { get; set; }
        public int Id { get; set; } 
        public List<SkillType> Skills { get; set; }
        public List<ServiceOffered> Services { get; set; }
        public Faction Faction { get; set; }
    }

    public enum SkillType
    {
        None,
        Espionage,
        Tracking,
        Assasination,
        Demolitions,
        Hacking,
        MartialArts

    }
    public enum ServiceOffered
    {
        None,
        PrivateInvestigation,
        Bodyguard,
        Security,
        Weddings,
        ArtHeist,
        Babysitting

    }
    public enum Faction
    {
        Neutral,
        Red,
        Blue,
    }
}
