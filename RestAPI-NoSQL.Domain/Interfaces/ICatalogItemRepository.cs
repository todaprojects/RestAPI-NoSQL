using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestAPI_NoSQL.Domain.Entities;

namespace RestAPI_NoSQL.Domain.Interfaces
{
    public interface ICatalogItemRepository
    {
        Task<CatalogItem> GetAsync(Guid id);
        Task<IReadOnlyCollection<CatalogItem>> GetAllAsync();
        Task CreateAsync(CatalogItem catalogItem);
    }
}