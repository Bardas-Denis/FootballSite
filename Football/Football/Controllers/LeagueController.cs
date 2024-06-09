using Microsoft.AspNetCore.Mvc;
using Football.Services;

namespace Football.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeagueController: ControllerBase
    {
        ILeagueCollectionService _leagueCollectionService;
        public LeagueController(ILeagueCollectionService leagueCollectionService)
        {
            _leagueCollectionService = leagueCollectionService ?? throw new ArgumentNullException(nameof(LeagueCollectionService));
        }
        /// <summary>
        /// This is a method used to get all leagues
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetLeagues()
        {
            return Ok(await _leagueCollectionService.GetAll());
        }

    }
}
