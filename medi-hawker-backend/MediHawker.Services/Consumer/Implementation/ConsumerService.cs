using MediHawker.Data;
using MediHawker.Repositories.Consumer.Interface;
using MediHawker.Services.Consumer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Services.Consumer.Implementation
{
    public class ConsumerService : IConsumerService
    {
        private readonly IConsumerRepository _consumerRepository;

        public ConsumerService(IConsumerRepository consumerRepository)
        {
            this._consumerRepository = consumerRepository;
        }
        public void Save(ConConsumers conConsumser)
        {
            _consumerRepository.Save(conConsumser);
        }
    }
}
