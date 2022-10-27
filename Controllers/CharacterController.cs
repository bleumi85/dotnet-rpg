using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    public class CharacterController : BaseApiController
    {
        private static Character knight = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}