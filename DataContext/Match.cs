using lol_stats_master_api.Models;
using lol_stats_master_api.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Xml.Linq;

namespace lol_stats_master_api.DataContext
{
    public class Match : IMatch
    {
        public async Task<List<string>?> GetMatchIds(string puuid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"https://americas.api.riotgames.com/lol/match/v5/matches/by-puuid/{puuid}/ids?api_key=RGAPI-1d25ece0-776f-4878-aade-771b5eea59ee");
                    if (response.IsSuccessStatusCode)
                    {
                        var ResponseContent = await response.Content.ReadAsStringAsync();
                        if (ResponseContent != null)
                        {
                            List<string> result = new List<string>();
                            result = JsonConvert.DeserializeObject<List<string>>(ResponseContent);
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

        public async Task<MatchDTO?> GetMatch(string matchId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"https://americas.api.riotgames.com/lol/match/v5/matches/{matchId}?api_key=RGAPI-1d25ece0-776f-4878-aade-771b5eea59ee");
                    if (response.IsSuccessStatusCode)
                    {
                        var ResponseContent = await response.Content.ReadAsStringAsync();
                        if (ResponseContent != null)
                        {
                            MatchDTO result = new MatchDTO();
                            result = JsonConvert.DeserializeObject<MatchDTO>(ResponseContent);
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
        /// <summary>
        /// gets all the matches for a user's encrypted puuid
        /// </summary>
        /// <param name="puuid"></param>
        /// <returns>a list of matches</returns>
        public async Task<MatchesDTO?> GetMatches(string puuid)
        {
            List<string>? ids = await GetMatchIds(puuid);
            if (ids == null)
            {
                return null;
            }
            MatchesDTO matches = new MatchesDTO();
            for (int i = 0; i < ids.Count; i++)
            {
                MatchDTO? item = await GetMatch(ids[i]);
                if (item == null)
                {
                    continue;
                }
                matches.Add(item);
            }
            return matches;
        }
    }
}
