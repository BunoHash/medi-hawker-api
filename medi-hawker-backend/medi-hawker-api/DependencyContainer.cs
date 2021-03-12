using MediHawker.Repositories.Auth.Implementation;
using MediHawker.Repositories.Auth.Interface;
using MediHawker.Repositories.Consumer.Implementation;
using MediHawker.Repositories.Consumer.Interface;
using MediHawker.Repositories.ConsumerCart.Implementation;
using MediHawker.Repositories.ConsumerCart.Interface;
using MediHawker.Repositories.Manufacture.Implementation;
using MediHawker.Repositories.Manufacture.Interface;
using MediHawker.Repositories.Product.Implementation;
using MediHawker.Repositories.Product.Interface;
using MediHawker.Services.Auth.Implemention;
using MediHawker.Services.Auth.Interface;
using MediHawker.Services.Consumer.Implementation;
using MediHawker.Services.Consumer.Interface;
using MediHawker.Services.ConsumerCart.Implementation;
using MediHawker.Services.ConsumerCart.Interface;
using MediHawker.Services.Manufacture.Implementation;
using MediHawker.Services.Manufacture.Interface;
using MediHawker.Services.Product.Implementation;
using MediHawker.Services.Product.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medi_hawker_api
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            //Services
            services.AddScoped<IConsumerService, ConsumerService>();
            services.AddScoped<IManufacturerService, ManufacturerService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICartService, CartService>();

            //Repositories
            services.AddScoped<IConsumerRepository, ConsumerRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            //JWT Token Config
            var key = configuration.GetSection("JWT:Secret").Value;
            var issuer = configuration.GetSection("JWT:ValidIssuer").Value;
            var audience = configuration.GetSection("JWT:ValidAudience").Value;

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = issuer,
                        ValidAudience = audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))

                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                context.Response.Headers.Add("Token-Expired", "true");
                            }
                            return Task.CompletedTask;
                        }
                    };
                });
        }
     }
}
