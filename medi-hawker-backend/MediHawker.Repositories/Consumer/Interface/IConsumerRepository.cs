using MediHawker.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Repositories.Consumer.Interface
{
   public interface IConsumerRepository 
    {
        void Save(ConConsumers conConsumers);
        bool Update(ConConsumers conConsumser);
    }
}
