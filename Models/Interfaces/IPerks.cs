namespace lol_stats_master_api.Models.Interfaces
{
    public interface IPerks
    {
        Statperks statPerks { get; set; }
        Style[] styles { get; set; }
    }
}