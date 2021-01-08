using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediHawker.Data;
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
            _consumerService=consumerService;
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

        // POST api/<controller>
        [HttpPost]
        [Route("saveRegisterConsumer")]
        public void saveRegisterConsumer(ConConsumers conConsumser)
        {
            this._consumerService.Save(conConsumser);
        }

        [HttpPost]
        [Route("updateRegisterConsumer")]
        public void updateRegisterConsumer(ConConsumers conConsumser)
        {
            
            this._consumerService.Update(conConsumser);
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
