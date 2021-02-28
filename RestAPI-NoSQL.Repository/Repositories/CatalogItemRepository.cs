using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using RestAPI_NoSQL.Domain.Entities;
using RestAPI_NoSQL.Domain.Interfaces;

namespace RestAPI_NoSQL.Repository.Repositories
{
    public class CatalogItemRepository : ICatalogItemRepository
    {
        private const string collectionName = "catalogitems";
        private readonly IMongoCollection<CatalogItem> dbCollection;
        private readonly FilterDefinitionBuilder<CatalogItem> filterBuilder = Builders<CatalogItem>.Filter;

        public CatalogItemRepository(IMongoDatabase database)
        {
            dbCollection = database.GetCollection<CatalogItem>(collectionName);
        }

        public async Task CreateAsync(CatalogItem catalogItem)
        {
            if (catalogItem == null)
            {
                throw new ArgumentNullException(nameof(catalogItem));
            }

            await dbCollection.InsertOneAsync(catalogItem);
        }

        public async Task<IReadOnlyCollection<CatalogItem>> GetAllAsync()
        {
            return await dbCollection.Find(filterBuilder.Empty).ToListAsync();
        }

        public async Task<CatalogItem> GetAsync(Guid id)
        {
            FilterDefinition<CatalogItem> filter = filterBuilder.Eq(catalogItem => catalogItem.Id, id);
            return await dbCollection.Find(filter).FirstOrDefaultAsync();
        }
    }
}