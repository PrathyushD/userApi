using Microsoft.AspNetCore.Mvc;
using userCore.Models;

namespace userApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // private readonly IConfiguration _config;
        private readonly IUserService _userService;
        //private IUsersHandlers @object;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }



        [HttpGet]
        public async Task<ActionResult<List<users>>> GetAllUsers()
        {

            var command = await _userService.GetUsers();
            return new ActionResult<List<users>>(command);
        }
    }
}