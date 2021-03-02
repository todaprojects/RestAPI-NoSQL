using System;
using MediatR;
using RestAPI_NoSQL.Domain.Entities;

namespace RestAPI_NoSQL.Application.Queries
{
    public class GetCatalogItemQuery : IRequest<CatalogItem>
    {
        public Guid Id { get; set; }
    }
}