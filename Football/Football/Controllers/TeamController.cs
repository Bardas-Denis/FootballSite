using Football.Services;
using Microsoft.AspNetCore.Mvc;

namespace Football.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        ITeamCollectionService _teamCollectionService;
        public TeamController(ITeamCollectionService teamCollectionService)
        {
            _teamCollectionService = teamCollectionService ?? throw new ArgumentNullException(nameof(TeamCollectionService));
        }
        /// <summary>
        /// This is a method used to get all teams
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetTeams()
        {
            return Ok(await _teamCollectionService.GetAll());
        }
        /// <summary>
        /// This is method used to get teams by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamById(int id)
        {
            var team = await _teamCollectionService.Get(id);
            if (team == null)
            {
                return NotFound("Team not found");
            }
            return Ok(team);
        }
    }
}
