using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.CustomModels.Auth
{
    class ConsumerInfo
    {
        public int CONSUMER_ID { get; set; }

        public string USER_NAME { get; set; }

        public string PHONE { get; set; }

        public DateTime CREATED_ON { get; set; }

        public int CREATED_BY { get; set; }

        public string PASSWORD { get; set; }

        public int CART_ITEM_COUNT { get; set; }
    }
}
