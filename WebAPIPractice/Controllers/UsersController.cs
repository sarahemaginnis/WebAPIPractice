using Microsoft.AspNetCore.Mvc;
using WebAPIPractice.Interfaces;
using WebAPIPractice.Models;
using WebAPIPractice.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserRepository repo = new UserRepository();
        public UsersController(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        private IUserRepository _userRepo;
     
        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User? Get(int id)
        {
            return _userRepo.GetById(id);
        }

        [HttpPost]
        public void Create([FromBody] User newUser)
        {
            _userRepo.Create(newUser);
        }

        [HttpPut("{id}")]
        public void Update([FromBody] User updatedUser)
        {
            _userRepo.Update(updatedUser);
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            _userRepo.Delete(id);
        }
    }
}
