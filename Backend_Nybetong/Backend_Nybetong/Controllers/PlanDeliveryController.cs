using Backend_Nybetong.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Nybetong.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanDeliveryController : ControllerBase
    {

        public readonly IPlanDelivery _planDelivery; 
        public PlanDeliveryController(IPlanDelivery planDelivery)
        {
            _planDelivery = planDelivery;
        }

        [HttpGet]
        public async Task<IActionResult> AsyncGetLitteras()
        {
            var litteras = await _planDelivery.AsyncGetLitteras();
            if (litteras == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "not found");
            }
            return StatusCode(StatusCodes.Status200OK, litteras);
        }
    }
}
