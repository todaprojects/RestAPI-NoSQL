using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RestAPI_NoSQL.Application.Queries;
using RestAPI_NoSQL.Domain.Entities;
using RestAPI_NoSQL.Domain.Interfaces;

namespace RestAPI_NoSQL.Application.Handlers
{
    public class GetAllCatalogItemsHandler : IRequestHandler<GetAllCatalogItemsQuery, IEnumerable<CatalogItem>>
    {
        private readonly ICatalogItemRepository _repository;

        public GetAllCatalogItemsHandler(ICatalogItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CatalogItem>> Handle(GetAllCatalogItemsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllCatalogItemsAsync();
        }
    }
}