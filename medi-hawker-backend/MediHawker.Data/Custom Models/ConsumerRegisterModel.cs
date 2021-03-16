using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Custom_Models
{
   public class ConsumerRegisterModel
    {

        public Consumer Consumer { get; set; }
        public ConsumersDetails ConsumerDetails{ get; set; }

        public ConsumerRegisterModel()
        {
            Consumer = new Consumer();
            ConsumerDetails = new ConsumersDetails();
        }
    }
}
