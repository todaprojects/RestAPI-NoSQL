using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using RestAPI_NoSQL.Application.Commands;
using RestAPI_NoSQL.Domain.Dtos;
using RestAPI_NoSQL.Domain.Entities;
using RestAPI_NoSQL.Domain.Interfaces;

namespace RestAPI_NoSQL.Application.Handlers
{
    public class AddCatalogItemHandler : IRequestHandler<AddCatalogItemCommand, CatalogItemDto>
    {
        private readonly ICatalogItemRepository _repository;
        private readonly IMapper _mapper;

        public AddCatalogItemHandler(ICatalogItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CatalogItemDto> Handle(AddCatalogItemCommand request, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<CatalogItem>(request);
            await _repository.AddCatalogItemAsync(item);

            return _mapper.Map<CatalogItemDto>(item);
        }
    }
}