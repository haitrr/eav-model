using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eav.DbContexts;
using Eav.Interfaces;
using MongoDB.Driver;


namespace Eav.Models
{
    // Unit of work is not implemented
    public class Repository<T> : IRepository<T> where T : DatabaseObject
    {
        private readonly EavDbContext _dbContext;
        private readonly IMongoCollection<T> _collection;

        public Repository(EavDbContext dbContext)
        {
            _dbContext = dbContext;
            _collection = _dbContext.GetCollection<T>();
        }

        public void Add(T obj)
        {
            _collection.InsertOneAsync(obj);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<bool> Update(Guid id, T obj)
        {
            ReplaceOneResult actionResult
                = await _collection
                    .ReplaceOneAsync(n => n.Id.Equals(id)
                        , obj
                        , new UpdateOptions { IsUpsert = true });
            return actionResult.IsAcknowledged
                   && actionResult.ModifiedCount > 0;
        }

        public async Task<bool> Remove(Guid id)
        {
            DeleteResult actionResult
                = await _collection.DeleteOneAsync(
                    Builders<T>.Filter.Eq("Id", id));

            return actionResult.IsAcknowledged
                   && actionResult.DeletedCount > 0;
        }


        public Task<T> GetByIdAsync(Guid id)
        {
            return _collection.Find(o => o.Id == id).SingleOrDefaultAsync();
        }

    }
}
