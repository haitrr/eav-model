using Eav.DbContexts;
using Eav.Interfaces;
using Eav.Models;

namespace Eav.Repositories
{
    public class EntityAttributeRepository : Repository<EntityAttribute>,IEntityAttributeRepository
    {
        public EntityAttributeRepository(EavDbContext dbContext):base(dbContext)
        {
        }
    }
}
