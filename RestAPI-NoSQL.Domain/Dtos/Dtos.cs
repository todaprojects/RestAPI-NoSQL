using System;
using System.ComponentModel.DataAnnotations;

namespace RestAPI_NoSQL.Domain.Dtos
{
    public class Dtos
    {
        public record CatalogItemDto(
            Guid Id,
            string Name,
            string Description,
            decimal Price,
            DateTimeOffset CreatedDate
        );

        public record CreateCatalogItemDto(
            [Required] string Name,
            string Description,
            [Range(0, 1000)] decimal Price
        );
    }
}