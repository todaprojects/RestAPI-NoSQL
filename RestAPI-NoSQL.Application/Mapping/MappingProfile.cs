using AutoMapper;
using RestAPI_NoSQL.Application.Commands;
using RestAPI_NoSQL.Domain.Dtos;
using RestAPI_NoSQL.Domain.Entities;

namespace RestAPI_NoSQL.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CatalogItem, CatalogItemDto>().ReverseMap();
            CreateMap<AddCatalogItemCommand, CatalogItem>().ReverseMap();
        }
    }
}