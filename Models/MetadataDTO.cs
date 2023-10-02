using lol_stats_master_api.Models.Interfaces;

namespace lol_stats_master_api.Models
{
    public class MetadataDTO : IMetadataDTO
    {
        public string dataVersion { get; set; }
        public string matchId { get; set; }
        public List<string> participants { get; set; }
    }
}
