using lol_stats_master_api.Models;
using lol_stats_master_api.Models.Interfaces;
using Newtonsoft.Json;

namespace lol_stats_master_api.DataContext
{
    public class Summoner : ISummoner
    {
        public async Task<ISummonerDTO?> GetSummonerByName(string name)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{name}?api_key=RGAPI-1d25ece0-776f-4878-aade-771b5eea59ee");
                    if (response.IsSuccessStatusCode)
                    {
                        var ResponseContent = await response.Content.ReadAsStringAsync();
                        if (ResponseContent != null)
                        {
                            ISummonerDTO result = new SummonerDTO();
                            result = JsonConvert.DeserializeObject<SummonerDTO>(ResponseContent);
                            return result;
                        }
                        return null;
                    }
                }
            }
            catch (Exception err)
            {   
                Console.WriteLine(err.ToString());
                return null;
            }
            return null;
        }
    }
}
