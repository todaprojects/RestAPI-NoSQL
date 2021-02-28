using RestAPI_NoSQL.Domain.Entities;

namespace RestAPI_NoSQL.Domain.Helpers
{
    public static class DtoHelper
    {
        public static Dtos.Dtos.CatalogItemDto AsDto(this CatalogItem item)
        {
            return new Dtos.Dtos.CatalogItemDto(
                    item.Id,
                    item.Name,
                    item.Description,
                    item.Price,
                    item.CreatedDate
                );
        }
    }
}