using Authentication.Infrastructure.Unitofwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Web.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitofwork unitofwork;

        public UserController(IUnitofwork unitofwork)
        {
            this.unitofwork = unitofwork;
        }

        [HttpGet("/user")]
        [Authorize]
        public async Task<IActionResult> getAllUsers()
        {
            var listAllUsers = unitofwork.Authentication.getAllUsers();
            return Ok(listAllUsers);
        }
    }
}
