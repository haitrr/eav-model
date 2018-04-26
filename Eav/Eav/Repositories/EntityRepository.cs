using Eav.DbContexts;
using Eav.Interfaces;
using Eav.Models;

namespace Eav.Repositories
{
    public class EntityRepository : Repository<Entity>,IEntityRepository
    {
        public EntityRepository(EavDbContext dbContext):base(dbContext)
        {
        }
    }
}
