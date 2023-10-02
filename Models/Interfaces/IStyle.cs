namespace lol_stats_master_api.Models.Interfaces
{
    public interface IStyle
    {
        string description { get; set; }
        Selection[] selections { get; set; }
        int style { get; set; }
    }
}