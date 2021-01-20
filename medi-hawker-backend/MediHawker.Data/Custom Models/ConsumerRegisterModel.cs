using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Custom_Models
{
   public class ConsumerRegisterModel
    {

        public ConConsumers Consumer { get; set; }
        public ConConsumersDetails ConsumerDetails{ get; set; }

        public ConsumerRegisterModel()
        {
            Consumer = new ConConsumers();
            ConsumerDetails = new ConConsumersDetails();
        }
    }
}
