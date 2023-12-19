
using AutoMapper;
using LMS.Data.Entities;
using LMS.Services.Models;
using LMS.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace AspNETWebAPIDersleri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<UserResponseModel>> Get()
        {
            var users =  await _userService.GetAllAsync();
            return _mapper.Map<IEnumerable<UserResponseModel>>(users);
        }

        [HttpGet("{id}")]
        public async Task<UserResponseModel> Get(int id)
        {
            var user =  await _userService.GetByIdAsync(id);
            return _mapper.Map<UserResponseModel>(user);
        }

        [HttpPost]
        public async Task<UserResponseModel> Post([FromBody] UserRequestModel userRequestModel)
        {
            var user = _mapper.Map<User>(userRequestModel);
            var createdUser =  await _userService.InsertAsync(user);
            return _mapper.Map<UserResponseModel>(createdUser);
        }

        [HttpPut]
        public async Task<UserResponseModel> Put([FromBody] UserRequestModel userRequestModel)
        {
            var user = _mapper.Map<User>(userRequestModel);
            var updatedUser =  await _userService.UpdateAsync(user);
            return _mapper.Map<UserResponseModel>(updatedUser);
        }

        [HttpDelete("{id}")]
        public async Task<UserResponseModel> Delete(int id)
        {
            var deletedUser =  await _userService.DeleteAsync(id);
            return _mapper.Map<UserResponseModel>(deletedUser);
        }
    }
}
