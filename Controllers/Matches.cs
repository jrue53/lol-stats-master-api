using Microsoft.AspNetCore.Mvc;
using lol_stats_master_api.Models;
using lol_stats_master_api.DataContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lol_stats_master_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Matches : ControllerBase
    {
        // GET: api/<Matches>
        [HttpGet]
        [Route("{puuid}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<MatchesDTO>> GetMatchesAsync(string puuid)
        {
            MatchesDTO? matches = await new Match().GetMatches(puuid);

            if(matches == null)
            {
                return NotFound();
            }

            return Ok(matches);
        }

    }
}
