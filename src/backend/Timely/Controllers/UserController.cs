using Microsoft.AspNetCore.Mvc;
using Timely.Models;

namespace Timely.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult CriarUser(User user)
        {
            _userRepository.Add(user);
            return CreatedAtAction(nameof(Get), new { id = user.UserId }, user);
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = _userRepository.Get(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            var users = _userRepository.GetAll();
            return Ok(users);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, User user)
        {
            if (id != user.UserId)
                return BadRequest();

            var existingUser = _userRepository.Get(id);
            if (existingUser is null)
                return NotFound();

            _userRepository.Update(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userRepository.Get(id);
            if (user is null)
                return NotFound();

            _userRepository.Delete(id);

            return NoContent();
        }
    }

}
