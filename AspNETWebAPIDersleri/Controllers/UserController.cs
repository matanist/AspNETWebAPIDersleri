
using AutoMapper;
using LMS.Data.Entities;
using LMS.Services.Models;
using LMS.Services.UserService;
using Microsoft.AspNetCore.Http;
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
        public async Task<IEnumerable<User>> Get()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<User> Post([FromBody] UserRequestModel userRequestModel)
        {
            //var user = new User
            //{
            //    Firstname = userRequestModel.Firstname, 
            //    Lastname = userRequestModel.Lastname,
            //    Email = userRequestModel.Email, 
            //    Password = userRequestModel.Password, 
            //    RoleId = userRequestModel.RoleId
            //};

            var user = _mapper.Map<User>(userRequestModel);
            return await _userService.InsertAsync(user);
        }

        [HttpPut]
        public async Task<User> Put([FromBody] User user)
        {
            return await _userService.UpdateAsync(user);
        }

        [HttpDelete("{id}")]
        public async Task<User> Delete(int id)
        {
            return await _userService.DeleteAsync(id);
        }
    }
}
