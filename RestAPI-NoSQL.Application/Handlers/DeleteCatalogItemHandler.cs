using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RestAPI_NoSQL.Application.Commands;
using RestAPI_NoSQL.Domain.Interfaces;

namespace RestAPI_NoSQL.Application.Handlers
{
    public class DeleteCatalogItemHandler : IRequestHandler<DeleteCatalogItemCommand, Guid?>
    {
        private readonly ICatalogItemRepository _repository;

        public DeleteCatalogItemHandler(ICatalogItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid?> Handle(DeleteCatalogItemCommand request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteCatalogItemAsync(request.Id);
        }
    }
}