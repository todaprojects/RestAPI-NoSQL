using RestAPI_NoSQL.Application.Commands;
using RestAPI_NoSQL.Domain.Dtos;

namespace RestAPI_NoSQL.Application.Mapping
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<AddCatalogItemDto, AddCatalogItemCommand>().ReverseMap();
        }
    }
}