using MediHawker.Repositories.Auth.Implementation;
using MediHawker.Repositories.Auth.Interface;
using MediHawker.Repositories.Consumer.Implementation;
using MediHawker.Repositories.Consumer.Interface;
using MediHawker.Services.Auth.Implemention;
using MediHawker.Services.Auth.Interface;
using MediHawker.Services.Consumer.Implementation;
using MediHawker.Services.Consumer.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medi_hawker_api
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            //Services
            services.AddScoped<IConsumerService, ConsumerService>();
            services.AddScoped<IAuthService, AuthService>();

            //Repositories
            services.AddScoped<IConsumerRepository, ConsumerRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
        }
     }
}
