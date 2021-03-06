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
        private const string CollectionName = "catalogitems";
        private readonly IMongoCollection<CatalogItem> _dbCollection;
        private readonly FilterDefinitionBuilder<CatalogItem> _filterBuilder = Builders<CatalogItem>.Filter;

        public CatalogItemRepository(IMongoDatabase database)
        {
            _dbCollection = database.GetCollection<CatalogItem>(CollectionName);
        }

        public async Task<CatalogItem> GetCatalogItemAsync(Guid id)
        {
            var filter = _filterBuilder.Eq(catalogItem => catalogItem.Id, id);
            return await _dbCollection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyCollection<CatalogItem>> GetAllCatalogItemsAsync()
        {
            return await _dbCollection.Find(_filterBuilder.Empty).ToListAsync();
        }

        public async Task AddCatalogItemAsync(CatalogItem catalogItem)
        {
            if (catalogItem == null)
            {
                throw new ArgumentNullException(nameof(catalogItem));
            }

            await _dbCollection.InsertOneAsync(catalogItem);
        }

        public async Task<Guid?> DeleteCatalogItemAsync(Guid id)
        {
            var filter = _filterBuilder.Eq(catalogItem => catalogItem.Id, id);
            var result = await _dbCollection.DeleteOneAsync(filter);

            if (result.DeletedCount != 0)
            {
                return id;
            }
            
            return null;
        }
    }
}