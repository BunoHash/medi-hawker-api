using MediHawker.Data;
using MediHawker.Data.Custom_Models;
using MediHawker.Services.Auth.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace medi_hawker_api.Controllers.Auth
{
    [Route("api/auth")]
    [ApiController]
    [Produces("application/json")]
    public class AuthController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("login")]
        public string LoginConsumer(ConsumerInfoModel model)
        {
            try
            {
               var loginResponse =  _authService.Login(model);
                if (loginResponse!=null)
                {
                    return loginResponse;
                }
                else {
                    return "Invalid User";
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return  "Invalid User";

            }
            
            
        }

        [HttpPost]
        [Route("logout")]
        public IActionResult Logout()
        {
            try
            {
                var loginResponse = _authService.Logout();
                if (loginResponse)
                {
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Bad request");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }


        }
    }
}
