using Eav.DbContexts;
using Eav.Interfaces;
using Eav.Models;

namespace Eav.Repositories
{
    public class AttributeValueRepository : Repository<AttributeValue>,IAttributeValueRepository
    {
        public AttributeValueRepository(EavDbContext dbContext):base(dbContext)
        {
        }
    }
}
