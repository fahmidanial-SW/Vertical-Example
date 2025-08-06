using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Vertical_Example.Features.CreateUser.CreateUser;

namespace Vertical_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] Command command)
        {
            if (command == null)
            {
                return BadRequest("Invalid user data.");
            }

            var response = await sender.Send(command);
            return CreatedAtAction(nameof(CreateUser), new { id = response.Name }, response);
        }

    }
}
