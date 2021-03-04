using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using RestAPI_NoSQL.Application.Handlers;
using RestAPI_NoSQL.Application.Mapping;
using RestAPI_NoSQL.Domain.Interfaces;
using RestAPI_NoSQL.Repository.Repositories;

namespace RestAPI_NoSQL.Application
{
    public static class ServiceInjection
    {
        public static IServiceCollection ConfigureServices()
        {
        IServiceCollection services = new ServiceCollection();
        
        services.AddSingleton(serviceProvider =>
            {
                const string connectionString = "mongodb://localhost:27017";
                var mongoClient = new MongoClient(connectionString);
                return mongoClient.GetDatabase("Catalog");
            });
            
        services.AddSingleton<ICatalogItemRepository, CatalogItemRepository>();
        
        services.AddScoped<IMediator, Mediator>();
        services.AddMediatR(typeof(AddCatalogItemHandler).Assembly);

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