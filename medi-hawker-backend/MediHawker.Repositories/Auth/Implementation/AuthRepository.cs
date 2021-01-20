using MediHawker.Data;
using MediHawker.Data.Custom_Models;
using MediHawker.Repositories.Auth.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediHawker.Repositories.Auth.Implementation
{
    public class AuthRepository : IAuthRepository
    {
        private readonly MedihawkerDbContext _context;

        public AuthRepository(MedihawkerDbContext context)
        {
            _context = context;
        }

        public ConConsumers GetUserNameAndPass(ConsumerInfoModel consumer)
        {
            try
            {
                var consumerDb = _context.ConConsumers.FirstOrDefault(x => x.UserName == consumer.UserName && x.Password == consumer.Password);
                if (consumerDb != null)
                {
                    return consumerDb;
                }
                else
                {
                    return new ConConsumers();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        

        public bool Logout()
        {
            return true;
        }
    }
}
