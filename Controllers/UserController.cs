using Dependency_Injection.Models;
using Dependency_Injection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public  class UserController(IGiftService giftService) : ControllerBase
    {
       // First Endpoint
        [HttpGet("")]
        public IActionResult Get()
        {
            var result = giftService.GetGifts();
            return Ok(result);
        }

        // Second Endpoint
        [HttpPost("send-gift")]
        public IActionResult SendAnotherGift([FromBody] GiftModel gift)
        {
            var result = giftService.AddGift(gift);

            return Ok(result);


        }



    }
}
