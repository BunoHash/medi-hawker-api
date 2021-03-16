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
        Data.Consumer GetUserNameAndPass(ConsumerInfoModel consumer);
    }
}
