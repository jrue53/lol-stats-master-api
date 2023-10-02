namespace lol_stats_master_api.Models.Interfaces
{
    public interface IBan
    {
        int championId { get; set; }
        int pickTurn { get; set; }
    }
}