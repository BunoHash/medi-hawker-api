using System;
using System.Collections.Generic;
using System.Text;
using MediHawker.Data;
using MediHawker.Data.Custom_Models;

namespace MediHawker.Repositories.Auth.Interface
{
    public interface IAuthRepository
    {
        bool Logout();
        ConConsumers GetUserNameAndPass(ConsumerInfoModel consumer);
    }
}
