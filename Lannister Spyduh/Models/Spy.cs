namespace Lannister_Spyduh.Models
{
    public class Spy
    {
        public string CodeName { get; set; }
        public int Id { get; set; } 
        public SkillType skillType { get; set; }
        public Service service { get; set; }
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
    public enum Service
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
