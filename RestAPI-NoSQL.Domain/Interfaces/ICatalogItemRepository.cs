using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestAPI_NoSQL.Domain.Entities;

namespace RestAPI_NoSQL.Domain.Interfaces
{
    public interface ICatalogItemRepository
    {
        Task CreateAsync(CatalogItem catalogItem);
        Task<IReadOnlyCollection<CatalogItem>> GetAllAsync();
        Task<CatalogItem> GetAsync(Guid id);
    }
}