using MediHawker.Data;
using MediHawker.Data.Custom_Models;
using MediHawker.Repositories.Auth.Interface;
using MediHawker.Services.Auth.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MediHawker.Data;

namespace MediHawker.Services.Auth.Implemention
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IConfiguration _config;

        public AuthService(IAuthRepository authRepository, IConfiguration config)
        {
            _authRepository = authRepository;
            _config = config;
        }

        public Data.Consumer Login(ConsumerInfoModel consumer)
        {
            Data.Consumer consumerFromDb = null;
            consumerFromDb = _authRepository.GetUserNameAndPass(consumer);
            return consumerFromDb;
            if(consumerFromDb!= null)
            {
                var token =GetTokenString(consumerFromDb);
            }
            return null;
        }

        private string GetTokenString(Data.Consumer consumerFromDb)
        {


            string key = _config.GetSection("JWT:Secret").Value;
            var issuer = _config.GetSection("JWT:ValidIssuer").Value;
            var audience = _config.GetSection("JWT:ValidAudience").Value;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var permClaims = new List<Claim>();
            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            permClaims.Add(new Claim("valid", "1"));
            permClaims.Add(new Claim("userid", consumerFromDb.ConsumerId.ToString()));
            permClaims.Add(new Claim("Username", consumerFromDb.UserName.ToString()));
            //permClaims.Add(new Claim("timeZone", userFromDb.TimezoneId.ToString()));


            var token = new JwtSecurityToken(issuer,
                audience,
                permClaims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);

            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt_token;


        }

        public bool Logout()
        {
            return _authRepository.Logout();
        }

        public string GetToken(Data.Consumer consumer)
        {
            try
            {
                 return GetTokenString(consumer);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
