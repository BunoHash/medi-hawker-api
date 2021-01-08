using MediHawker.Data;
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

        public void Save(ConConsumers conConsumers)
        {
            try
            {

                _context.ConConsumers.Add(conConsumers);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
        }

        public bool Update(ConConsumers conConsumser)
        {
            try
            {
               var consumer  = _context.ConConsumers.FirstOrDefault(x => x.ConsumerId==conConsumser.ConsumerId);
                if (consumer != null)
                {
                    consumer.CartItemCount = conConsumser.CartItemCount;
                    consumer.Password = conConsumser.Password;
                    consumer.Phone = conConsumser.Phone;
                    consumer.UserName = conConsumser.UserName;

                    return _context.SaveChanges() >0;
                }

            }
            catch (Exception)
            {
                
                throw;
            }
            return true;
        }
    }
}
