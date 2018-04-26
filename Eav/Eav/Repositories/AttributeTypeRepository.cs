using Eav.DbContexts;
using Eav.Interfaces;
using Eav.Models;

namespace Eav.Repositories
{
    public class AttributeTypeRepository : Repository<AttributeType>,IAttributeTypeRepository
    {
        public AttributeTypeRepository(EavDbContext dbContext):base(dbContext)
        {
        }
    }
}
