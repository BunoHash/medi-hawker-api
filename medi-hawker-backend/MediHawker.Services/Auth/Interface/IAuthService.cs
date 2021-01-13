using System;
using System.Collections.Generic;
using System.Text;
using MediHawker.Data.Custom_Models;

namespace MediHawker.Services.Auth.Interface
{
    public interface IAuthService
    {
        string Login(ConsumerInfoModel consumer);
        bool Logout();
    }
}
