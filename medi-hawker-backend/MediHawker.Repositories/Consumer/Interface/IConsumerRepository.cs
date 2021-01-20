using MediHawker.Data;
using MediHawker.Data.Custom_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Repositories.Consumer.Interface
{
   public interface IConsumerRepository 
    {
        bool Save(ConsumerRegisterModel conModel);
        bool Update(ConsumerRegisterModel conModel);
    }
}
