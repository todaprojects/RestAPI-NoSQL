using System.ComponentModel.DataAnnotations;

namespace RestAPI_NoSQL.Domain.Dtos
{
    public record AddCatalogItemDto(
        [Required] string Name,
        string Description,
        [Range(0, 1000)] decimal Price
    );
}