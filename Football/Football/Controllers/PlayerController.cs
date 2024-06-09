using Football.Services;
using Microsoft.AspNetCore.Mvc;

namespace Football.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController: ControllerBase
    {
        IPlayerCollectionService _playerCollectionService;
        public PlayerController(IPlayerCollectionService playerCollectionService)
        {
            _playerCollectionService = playerCollectionService ?? throw new ArgumentNullException(nameof(PlayerCollectionService));
        }
        /// <summary>
        /// This is a method used to get all player
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            return Ok(await _playerCollectionService.GetAll());
        }
        /// <summary>
        /// This is method used to get players by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlayerById(int id)
        {
            var player = await _playerCollectionService.Get(id);
            if (player == null)
            {
                return NotFound("Player not found");
            }
            return Ok(player);
        }
    }
}
