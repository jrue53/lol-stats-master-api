using lol_stats_master_api.Models;

namespace lol_stats_master_api.DataContext
{
    public interface IMatch
    {
        Task<MatchDTO?> GetMatch(string matchId);
        Task<MatchesDTO?> GetMatches(string puuid);
        Task<List<string>?> GetMatchIds(string puuid);
    }
}