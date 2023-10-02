using System.ComponentModel;
using lol_stats_master_api.Models.Interfaces;

namespace lol_stats_master_api.Models
{
    public enum GameType
    {
        [Description("all other games")]
        MATCHED_GAME,
        [Description("Custom games")]
        CUSTOM_GAME,
        [Description("Tutorial games")]
        TUTORIAL_GAME
    }

    public class MatchesDTO : List<MatchDTO>
    {
    }
    public class MatchDTO : IMatchDTO
    {
        public InfoDTO info { get; set; }
        public MetadataDTO metadata { get; set; }


    }
}
