using AutoMapper;
using BlackLotus.Data;
using BlackLotus.DTO;
using BlackLotus.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlackLotus.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly IUserRepo userRepo;
        private readonly IMapper mapper;

        public UserController(IUserRepo _userRepo, IMapper _mapper)

        {
            userRepo = _userRepo;
            mapper = _mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDTO>> GetUser()
        {
            var user = userRepo.GetUsers();
            return Ok(mapper.Map<IEnumerable<UserReadDTO>>(user));
        }
        [HttpGet("{userId}", Name = "GetUserById")]
        public ActionResult<UserReadDTO> GetUserById(int userId)
        {
            var user = userRepo.GetUserById(userId);
            if (user != null)
                return Ok(mapper.Map<UserReadDTO>(user));
            else
                return NotFound();
        }


        [HttpPost]
        public ActionResult<UserCreateDTO> CreateUser(UserCreateDTO user)
        {
            var userModel = mapper.Map<User>(user);
            userRepo.createUser(userModel);
            userRepo.Save();

            var newUser = mapper.Map<UserReadDTO>(userModel);
            return CreatedAtRoute(nameof(GetUserById), new { userId = newUser.userId}, newUser);

        }
        [HttpDelete("{userId}")]

        public ActionResult Delete(int userId)
        {
            var userToDelete = userRepo.GetUserById(userId);
            if (userToDelete == null)
                return NotFound();
            userRepo.delete(userToDelete);
            return Ok();

        }
        [HttpPut]
        public ActionResult Update(int userId, UserCreateDTO user)
        {
            var updateUser = mapper.Map<User>(user);
            updateUser.userId = userId;
            if (!userRepo.update(updateUser))
                return NotFound();
            else
                return Ok();

        }
    }
}

