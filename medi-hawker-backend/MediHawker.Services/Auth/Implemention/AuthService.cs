using MediHawker.Data.Custom_Models;
using MediHawker.Repositories.Auth.Interface;
using MediHawker.Services.Auth.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Services.Auth.Implemention
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public bool Login(ConsumerInfoModel consumer)
        {
            return _authRepository.Login(consumer);
        }

        public bool Logout()
        {
            return _authRepository.Logout();
        }
    }
}
