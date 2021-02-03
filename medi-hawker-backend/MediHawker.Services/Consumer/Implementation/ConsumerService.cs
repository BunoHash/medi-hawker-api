using MediHawker.Data;
using MediHawker.Data.Custom_Models;
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

        public bool CheckEmail(string email)
        {
            return _consumerRepository.CheckEmail(email);
        }
        public bool CheckUsername(string email)
        {
            return _consumerRepository.CheckUsername(email);
        }
        

        public bool Save(ConsumerRegisterModel conModel)
        {
            return _consumerRepository.Save(conModel);
        }

        public bool Update(ConsumerRegisterModel conModel)
        {
            return _consumerRepository.Update(conModel);
             
        }
        
    }
}
