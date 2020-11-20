using Easypeasy.User.Service.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Easypeasy.User.Service.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userservice;
        public UserController(IUserService userservice)
        {
            _userservice = userservice;
        }

        [HttpGet]
        [Route("getuserbyid")]
        public async Task<IActionResult> GetUserById(string userid)
        {
            return Ok(new Domain.User { userid = userid });
        }
    }
}