using lol_stats_master_api.Models.Interfaces;

namespace lol_stats_master_api.DataContext
{
    public interface ISummoner
    {
        Task<ISummonerDTO?> GetSummonerByName(string name);
    }
}