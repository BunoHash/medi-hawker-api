using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Custom_Models
{
   public class LoginSuccessModel
    {
        public Consumer User { get; set; }
        public string Token { get; set; }
    }
}
