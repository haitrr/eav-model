using System;
using Eav.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Eav.DbContexts
{
    public class EavDbContext
    {
        private readonly IMongoDatabase _database = null;
        public EavDbContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<T> GetCollection<T>() where T : DatabaseObject
        {
            return _database.GetCollection<T>(GetCollectionName(typeof(T)));
        }

        private string GetCollectionName(Type type)
        {
            if (type == typeof(Entity))
            {
                return "Entities";
            }
            else if (type == typeof(EntityAttribute))
            {
                return "EntityAttributes";
            }
            else if (type == typeof(EntityType))
            {
                return "EntityTypes";
            }
            else if (type == typeof(AttributeType))
            {
                return "AttributeTypes";
            }
            else if (type == typeof(AttributeValue))
            {
                return "AttributeValies";
            }
            else if (type == typeof(Relationship))
            {
                return "Relationships";
            }

            throw new NotImplementedException();
        }


        public IMongoCollection<Entity> Entities => _database.GetCollection<Entity>("Entities");
        public IMongoCollection<EntityAttribute> EntityAttributes => _database.GetCollection<EntityAttribute>("EntityAttributes");
        public IMongoCollection<EntityType> EntityTypes => _database.GetCollection<EntityType>("EntityTypes");
        public IMongoCollection<Relationship> Relationships => _database.GetCollection<Relationship>("Relationships");
        public IMongoCollection<AttributeType> AttributeTypes => _database.GetCollection<AttributeType>("AttributeTypes");
        public IMongoCollection<AttributeValue> AttributeValues => _database.GetCollection<AttributeValue>("AttributeValues");
    }
}
