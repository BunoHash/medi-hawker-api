using MediHawker.Repositories.Consumer.Implementation;
using MediHawker.Repositories.Consumer.Interface;
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

            //Repositories
            services.AddScoped<IConsumerRepository, ConsumerRepository>();
        }
     }
}
