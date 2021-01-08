using MediHawker.Data;
using MediHawker.Repositories.Consumer.Interface;
using System;
using System.Collections.Generic;
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
    }
}
