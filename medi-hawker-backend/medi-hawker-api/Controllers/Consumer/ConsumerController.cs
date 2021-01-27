using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediHawker.Data;
using MediHawker.Data.Custom_Models;
using MediHawker.Services.Consumer.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace medi_hawker_api.Controllers.Consumer
{
    [Route("api/consumer")]
    [ApiController]
    [Produces("application/json")]
    public class ConsumerController : Controller
    {
        private readonly IConsumerService _consumerService;
        public ConsumerController(IConsumerService consumerService)
        {
            _consumerService = consumerService;
        }
        // GET: api/<controller>
        [HttpGet]
        [Route("test")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        //POST api for emailAlreayExists
        [HttpPost]
        [Route("emailAlreayExists")]
        public bool emailAlreayExists(string email)
        {
            return this._consumerService.CheckEmail(email);
        }

        //POST api for userAlreayExists
        [HttpPost]
        [Route("userNameAlreayExists")]
        public bool userNameAlreayExists(string username)
        {
            return this._consumerService.CheckUsername(username);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("saveRegisterConsumer")]
        public bool saveRegisterConsumer(ConsumerRegisterModel consumer)
        {
           var response = this._consumerService.Save(consumer);
            return response;
           // Console.WriteLine(consumerInfo.ConsumerId);
        }

        [HttpPost]
        [Route("updateRegisterConsumer")]
        public IActionResult updateRegisterConsumer(ConsumerRegisterModel conModel)
        {
            
            var response = this._consumerService.Update(conModel);

            if (response)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest("bad request!");
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    
}
