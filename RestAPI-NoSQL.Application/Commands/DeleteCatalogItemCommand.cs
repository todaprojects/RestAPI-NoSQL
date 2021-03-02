using System;
using MediatR;

namespace RestAPI_NoSQL.Application.Commands
{
    public class DeleteCatalogItemCommand : IRequest<Guid?>
    {
        public Guid Id { get; set; }
    }
}