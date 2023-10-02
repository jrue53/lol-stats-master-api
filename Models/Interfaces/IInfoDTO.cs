namespace lol_stats_master_api.Models.Interfaces
{
    public interface IInfoDTO
    {
        long gameCreation { get; set; }
        long gameDuration { get; set; }
        long gameEndTimestamp { get; set; }
        long gameId { get; set; }
        string gameMode { get; set; }
        string gameName { get; set; }
        long gameStartTimestamp { get; set; }
        string gameType { get; set; }
        string gameVersion { get; set; }
        int mapId { get; set; }
        string platformId { get; set; }
        int queueId { get; set; }
        string tournamentCode { get; set; }
    }
}