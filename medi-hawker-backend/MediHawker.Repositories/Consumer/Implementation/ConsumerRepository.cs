using MediHawker.Data;
using MediHawker.Data.Custom_Models;
using MediHawker.Repositories.Consumer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediHawker.Repositories.Consumer.Implementation
{
  public  class ConsumerRepository : IConsumerRepository
    {

        private readonly MedihawkerDbContext _context;

        public ConsumerRepository(MedihawkerDbContext context)
        {
            _context = context;
        }

        public bool Save(ConsumerRegisterModel conModel)
        {
            try
            {

                //for consumer
                conModel.Consumer.CreatedOn = DateTime.UtcNow;
                _context.ConConsumers.Add(conModel.Consumer);
                _context.SaveChanges();

                //for consumer detail
                conModel.ConsumerDetails.ConsumerId = conModel.Consumer.ConsumerId;
                conModel.ConsumerDetails.CreatedOn = DateTime.UtcNow;
                _context.ConConsumersDetails.Add(conModel.ConsumerDetails);
               
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _context.SaveChanges() > 0;
        }

        public bool Update(ConsumerRegisterModel conModel)
        {
            try
            {
               var consumer  = _context.ConConsumers.FirstOrDefault(x => x.ConsumerId==conModel.Consumer.ConsumerId);
                if (consumer != null)
                {
                    consumer.CartItemCount = conModel.Consumer.CartItemCount;
                    consumer.Password = conModel.Consumer.Password;
                    consumer.Phone = conModel.Consumer.Phone;
                    consumer.UserName = conModel.Consumer.UserName;
                    consumer.CreatedOn = DateTime.UtcNow;

                     _context.SaveChanges();
                }

                var consumerDetails = _context.ConConsumersDetails.FirstOrDefault(x => x.ConsumerId == conModel.ConsumerDetails.ConsumerId);
                if (consumerDetails != null)
                {
                    consumerDetails.FirstName = conModel.ConsumerDetails.FirstName;
                    consumerDetails.LastName = conModel.ConsumerDetails.LastName;
                    consumerDetails.Email = conModel.ConsumerDetails.Email;
                    consumerDetails.Address = conModel.ConsumerDetails.Address;
                    consumerDetails.CreatedOn = DateTime.UtcNow;

                   
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return _context.SaveChanges() > 0;
        }
    }
}
