using lol_stats_master_api.Models.Interfaces;

namespace lol_stats_master_api.Models
{
    public class Perks : IPerks
    {
        public Statperks statPerks { get; set; }
        public Style[] styles { get; set; }
    }

    public class Statperks : IStatperks
    {
        public int defense { get; set; }
        public int flex { get; set; }
        public int offense { get; set; }
    }

    public class Style : IStyle
    {
        public string description { get; set; }
        public Selection[] selections { get; set; }
        public int style { get; set; }
    }

    public class Selection : ISelection
    {
        public int perk { get; set; }
        public int var1 { get; set; }
        public int var2 { get; set; }
        public int var3 { get; set; }
    }

    public class Team : ITeam
    {
        public List<Ban> bans { get; set; }
        public Objectives objectives { get; set; }
        public int teamId { get; set; }
        public bool win { get; set; }
    }

    public class Objectives : IObjectives
    {
        public ObjectiveDTO baron { get; set; }
        public ObjectiveDTO champion { get; set; }
        public ObjectiveDTO dragon { get; set; }
        public ObjectiveDTO inhibitor { get; set; }
        public ObjectiveDTO riftHerald { get; set; }
        public ObjectiveDTO tower { get; set; }
    }

    public class ObjectiveDTO : IObjectiveDTO
    {
        public bool first { get; set; }
        public int kills { get; set; }
    }

    public class Ban : IBan
    {
        public int championId { get; set; }
        public int pickTurn { get; set; }
    }
}
