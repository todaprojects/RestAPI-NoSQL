using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RestAPI_NoSQL.Application.Commands;
using RestAPI_NoSQL.Domain.Dtos;
using RestAPI_NoSQL.Domain.Entities;
using RestAPI_NoSQL.Domain.Interfaces;

namespace RestAPI_NoSQL.Application.Handlers
{
    public class AddCatalogItemHandler : IRequestHandler<AddCatalogItemCommand, CatalogItem>
    {
        private readonly ICatalogItemRepository _repository;

        public AddCatalogItemHandler(ICatalogItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<CatalogItem> Handle(AddCatalogItemCommand request, CancellationToken cancellationToken)
        {
            var item = new CatalogItem
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };
            await _repository.AddCatalogItemAsync(item);

            return item;
        }
    }
}