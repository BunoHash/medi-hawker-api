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
        public IActionResult LoginConsumer(ConsumerInfoModel consumer)
        {
            try
            {
               var loginResponse =  _authService.Login(consumer);
                if (loginResponse!=null)
                {
                    return Ok(loginResponse);
                }
                else {
                    return Unauthorized("Invalid User");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                var msg = new HttpResponseException(HttpStatusCode.Unauthorized) { var ResponsePhrase = "Oops!!" };
                throw new HttpResponseException(msg);
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
