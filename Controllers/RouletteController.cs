using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BettingRoulette.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouletteController : ControllerBase
    {
        [HttpPost]
        public IActionResult create()
        {
            // Try to create a new roulette
            var rouletteId = 0;
            if (rouletteId > 0)
            {
                return Ok(rouletteId);
            }

            return BadRequest("The new roulette wasn't created.");
        }

        [HttpPost]
        public IActionResult open(long id)
        {
            // Try to open roulette
            var result = true;
            if (result)
            {
                return Ok("Roulette opened successfully.");
            }
            else
            {
                return BadRequest("Failed open roulette.");
            }
        }

        [HttpPost]
        public IActionResult bet()
        {
            return Ok("");
        }

        public IActionResult close(long id)
        {

        }
    }
}
