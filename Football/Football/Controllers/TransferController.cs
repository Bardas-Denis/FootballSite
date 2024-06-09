using Football.Services;
using Microsoft.AspNetCore.Mvc;

namespace Football.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController: ControllerBase
    {

        ITransferCollectionService _transferCollectionService;
        public TransferController(ITransferCollectionService transferCollectionService)
        {
            _transferCollectionService = transferCollectionService ?? throw new ArgumentNullException(nameof(TransferCollectionService));
        }
        /// <summary>
        /// This is a method used to get all transfers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetTransfers()
        {
            return Ok(await _transferCollectionService.GetAll());
        }
    }
}
