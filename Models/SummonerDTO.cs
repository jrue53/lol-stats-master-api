using lol_stats_master_api.Models.Interfaces;

namespace lol_stats_master_api.Models
{
    public class SummonerDTO : ISummonerDTO
    {
        public string accountId { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string puuid { get; set; }
        public long summonerLevel { get; set; }
    }
}
