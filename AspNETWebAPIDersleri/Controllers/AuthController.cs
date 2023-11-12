using AspNETWebAPIDersleri.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNETWebAPIDersleri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost()]
        public ResponseModel Login(LoginModel loginModel)
        {

            if (loginModel.Username == "fatih" && loginModel.Password == "123")
            {
                return new ResponseModel()
                {
                    Message = "Login işlemi başarılı",
                    Code = "200",
                    Data = null
                };

            }

            return new ResponseModel()
            {
                Message = "Login işlemi başarısız",
                Code = "401",
                Data = null
            };

        }
    }
}
