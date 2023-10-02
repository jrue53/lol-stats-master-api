namespace lol_stats_master_api.Models.Interfaces
{
    public interface ISummonerDTO
    {
        string accountId { get; set; }
        int profileIconId { get; set; }
        long revisionDate { get; set; }
        string name { get; set; }
        string id { get; set; }
        string puuid { get; set; }
        long summonerLevel { get; set; }
    }
}
