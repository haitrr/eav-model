using System.Collections.Generic;
using System.Threading.Tasks;
using Eav.Interfaces;
using Eav.Models;

namespace Eav.Services
{
    public class EntityService : IEntityService
    {
        private readonly IEntityRepository _entityRepository;

        public EntityService(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public Task<IEnumerable<Entity>> GetAll()
        {
            return _entityRepository.GetAll();
        }

        public async Task Add(Entity entity)
        {
            await _entityRepository.Add(entity);
        }
    }

    public interface IEntityService
    {
        Task<IEnumerable<Entity>> GetAll();
        Task Add(Entity entity);
    }
}
