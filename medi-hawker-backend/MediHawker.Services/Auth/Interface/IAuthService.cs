using System;
using System.Collections.Generic;
using System.Text;
using MediHawker.Data.Custom_Models;

namespace MediHawker.Services.Auth.Interface
{
    public interface IAuthService
    {
        Data.Consumer Login(ConsumerInfoModel consumer);
        bool Logout();
        string GetToken(Data.Consumer consumer);
    }
}
