namespace lol_stats_master_api.Models.Interfaces
{
    public interface IObjectives
    {
        ObjectiveDTO baron { get; set; }
        ObjectiveDTO champion { get; set; }
        ObjectiveDTO dragon { get; set; }
        ObjectiveDTO inhibitor { get; set; }
        ObjectiveDTO riftHerald { get; set; }
        ObjectiveDTO tower { get; set; }
    }
}