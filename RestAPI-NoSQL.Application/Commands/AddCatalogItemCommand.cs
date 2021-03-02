using MediatR;
using RestAPI_NoSQL.Domain.Entities;

namespace RestAPI_NoSQL.Application.Commands
{
    public class AddCatalogItemCommand : IRequest<CatalogItem>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}