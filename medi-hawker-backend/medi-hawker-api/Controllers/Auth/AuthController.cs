using MediHawker.Data.Custom_Models;
using MediHawker.Data;
using MediHawker.Services.Auth.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        public LoginSuccessModel LoginConsumer(ConsumerInfoModel model)
        {
            try
            {
                var dbConsumer = _authService.Login(model);
                if (dbConsumer != null)
                {

                    var successModel = new LoginSuccessModel();

                    successModel.Token = _authService.GetToken(dbConsumer);
                    successModel.User = dbConsumer;
                    string jsonString = JsonSerializer.Serialize(successModel);
                    //string consumerJson;//=  consumer k  Seriali e korba
                    //return Ok(successModel);
                    return successModel;
                }
                //if (loginResponse!=null)
                //{
                //    return loginResponse;
                //}
                //else {
                //    return "Invalid User";
                //}

                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

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
