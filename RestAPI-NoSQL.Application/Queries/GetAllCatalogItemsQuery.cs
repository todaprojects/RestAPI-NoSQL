using System.Collections.Generic;
using MediatR;
using RestAPI_NoSQL.Domain.Entities;

namespace RestAPI_NoSQL.Application.Queries
{
    public class GetAllCatalogItemsQuery : IRequest<IEnumerable<CatalogItem>>
    {
    }
}