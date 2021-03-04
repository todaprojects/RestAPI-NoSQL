using System;
using MediatR;
using RestAPI_NoSQL.Domain.Dtos;

namespace RestAPI_NoSQL.Application.Commands
{
    public class AddCatalogItemCommand : IRequest<CatalogItemDto>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
    }
}