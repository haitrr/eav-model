using Eav.DbContexts;
using Eav.Interfaces;
using Eav.Models;

namespace Eav.Repositories
{
    public class EntityTypeRepository : Repository<EntityType>,IEntityTypeRepository
    {
        public EntityTypeRepository(EavDbContext dbContext):base(dbContext)
        {
        }
    }
}
