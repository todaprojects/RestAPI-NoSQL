using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestAPI_NoSQL.Domain.Entities;

namespace RestAPI_NoSQL.Domain.Interfaces
{
    public interface ICatalogItemRepository
    {
        Task<CatalogItem> GetCatalogItemAsync(Guid id);
        Task<IReadOnlyCollection<CatalogItem>> GetAllCatalogItemsAsync();
        Task AddCatalogItemAsync(CatalogItem catalogItem);
        Task<Guid> DeleteCatalogItemAsync(Guid id);
    }
}