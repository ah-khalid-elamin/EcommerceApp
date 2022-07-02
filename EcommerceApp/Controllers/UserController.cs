using EcommerceApp.Models;
using EcommerceApp.Services;


using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }
        [HttpGet("{id}")]
        public IActionResult GetUser([FromRoute] Guid id)
        {
            var user = _userService.GetUser(id);
            if (user != null) 
            { 
                return Ok(user);
            }
            return NotFound($"User with Id:{id} was not found");
            
        }
        [HttpPost]
        public IActionResult GetUser(User user)
        {
            _userService.AddUser(user);
            return Ok("User Created");
            

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            var user = _userService.GetUser(id);
            if (user != null)
            {
                _userService.DeleteUser(user);
                return Ok("the user deleted");
            }
            return NotFound($"User with Id:{id} was not found");

        }
        [HttpPatch("{id}")]
        public IActionResult EditUser([FromRoute] Guid id,User user)
        {
            var existingUser  = _userService.GetUser(id);
            if (existingUser != null)
            {
                _userService.UpdateUser(user);
                return Ok(user);
            }
            return NotFound($"User with Id:{id} was not found");

        }
    }
}
