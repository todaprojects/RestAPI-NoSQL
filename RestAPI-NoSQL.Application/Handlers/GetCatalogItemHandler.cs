using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RestAPI_NoSQL.Application.Queries;
using RestAPI_NoSQL.Domain.Entities;
using RestAPI_NoSQL.Domain.Interfaces;

namespace RestAPI_NoSQL.Application.Handlers
{
    public class GetCatalogItemHandler : IRequestHandler<GetCatalogItemQuery, CatalogItem>
    {
        private readonly ICatalogItemRepository _repository;

        public GetCatalogItemHandler(ICatalogItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<CatalogItem> Handle(GetCatalogItemQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetCatalogItemAsync(request.Id);
        }
    }
}