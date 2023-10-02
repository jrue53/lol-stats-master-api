using lol_stats_master_api.Models.Interfaces;

namespace lol_stats_master_api.Models
{
    public class InfoDTO : IInfoDTO
    {
        public long gameCreation { get; set; }
        public long gameDuration { get; set; }
        public long gameEndTimestamp { get; set; }
        public long gameId { get; set; }
        public string gameMode { get; set; }
        public string gameName { get; set; }
        public long gameStartTimestamp { get; set; }
        public string gameType { get; set; }
        public string gameVersion { get; set; }
        public int mapId { get; set; }
        public string platformId { get; set; }
        public int queueId { get; set; }
        public string tournamentCode { get; set; }

        public List<ParticipantDTO> participants { get; set; }

        public List<Team> teams { get; set; }
    }
}
