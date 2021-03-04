using MediatR;
using RestAPI_NoSQL.Domain.Dtos;

namespace RestAPI_NoSQL.Application.Commands
{
    public class UpdateCatalogItemCommand : IRequest<CatalogItemDto>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}