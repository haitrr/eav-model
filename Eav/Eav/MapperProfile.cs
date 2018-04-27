using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eav.Controllers;
using Eav.Models;

namespace Eav
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<EntityViewModel, Entity>().ReverseMap();
            CreateMap<AttributeValueViewModel, AttributeValue>().ReverseMap();
        }
    }
}
