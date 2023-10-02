using lol_stats_master_api.DataContext;
using lol_stats_master_api.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lol_stats_master_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoLAccount : ControllerBase
    {
        private ISummoner _summonerContext;
        public LoLAccount(ISummoner summonerContext)
        {
            _summonerContext = summonerContext;
        }

        // GET api/<LoLAccount>/5
        [HttpGet]
        [Route("summoner/{name}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ISummonerDTO>> GetSummonerAsync(string name)
        {

            ISummonerDTO? summoner = await _summonerContext.GetSummonerByName(name);

            if (summoner == null )
            {
                return NotFound();
            }

            return Ok(summoner);
        }

    }
}
