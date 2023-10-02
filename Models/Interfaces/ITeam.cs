namespace lol_stats_master_api.Models.Interfaces
{
    public interface ITeam
    {
        List<Ban> bans { get; set; }
        Objectives objectives { get; set; }
        int teamId { get; set; }
        bool win { get; set; }
    }
}