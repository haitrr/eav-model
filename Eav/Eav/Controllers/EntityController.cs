using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using AutoMapper;
using Eav.Models;
using Eav.Services;
using Microsoft.AspNetCore.Mvc;

namespace Eav.Controllers
{
    [Route("api/entity")]
    public class EntityController : Controller
    {
        private readonly IEntityService _entityService;
        private readonly IMapper _mapper;

        public EntityController(IEntityService entityService, IMapper mapper)
        {
            _entityService = entityService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] EntityViewModel model)
        {
            var entity = _mapper.Map<Entity>(model);
             await _entityService.Add(entity);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<Entity> entities = await _entityService.GetAll();
            var viewModel = _mapper.Map<IEnumerable<EntityViewModel>>(entities);
            return Ok(viewModel);
        }
    }

    public class EntityViewModel
    {
        public Guid TypeId { get; set; }
        public ICollection<AttributeValueViewModel> Properties { get; set; }
    }

    public class AttributeValueViewModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Guid EntityAttributeId { get; set; }
    }
}