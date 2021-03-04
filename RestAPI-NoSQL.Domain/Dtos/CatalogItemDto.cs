using System;

namespace RestAPI_NoSQL.Domain.Dtos
{
    public record CatalogItemDto(
        Guid Id,
        string Name,
        string Description,
        decimal Price,
        DateTimeOffset CreatedDate
    );
}