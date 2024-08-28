using BeeHive.WebAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BeeHive.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        [HttpPost("/measurementapi")]
        public IActionResult MeasurementAPI([FromBody] MeasurementAPIInputDTO measurement)
        {
            return Ok();
        }

        [HttpPost("/textdetectionapi")]
        public IActionResult TextDetectionAPI([FromBody] TextDetectionAPIInputDTO textDetection)
        {
            return Ok();
        }
    }
}
