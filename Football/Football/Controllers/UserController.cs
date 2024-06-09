using Football.Services;
using Microsoft.AspNetCore.Mvc;
using FootballDB;
namespace Football.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        IUserCollectionService _userCollectionService;
        public UserController(IUserCollectionService userCollectionService)
        {
            _userCollectionService = userCollectionService ?? throw new ArgumentNullException(nameof(UserCollectionService));
        }
        /// <summary>
        /// This is a method used to get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userCollectionService.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            await _userCollectionService.Add(user);
            return Ok();
        }
    }
}
