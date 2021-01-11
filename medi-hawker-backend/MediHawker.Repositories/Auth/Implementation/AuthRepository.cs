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

        public bool Login(ConsumerInfoModel consumer)
        {
            try
            {
                var consumerDb = _context.ConConsumers.FirstOrDefault(x => x.UserName == consumer.UserName);
                if (consumerDb != null)
                {
                    return true;
                }
                else
                {
                    return false;
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
