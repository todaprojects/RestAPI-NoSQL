using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RestAPI_NoSQL.Application.Mapping;

namespace RestAPI_NoSQL.Application
{
    public class DependencyInjection
    {
        public static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            
            return services;
        }
    }
}