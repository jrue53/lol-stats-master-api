namespace lol_stats_master_api.Models.Interfaces
{
    public interface IMetadataDTO
    {
        string dataVersion { get; set; }
        string matchId { get; set; }
        List<string> participants { get; set; }
    }
}