using System;
using System.Collections.Generic;

namespace Eav.Models
{
    public class EntityType : DatabaseObject
    {
        public string Name { get; set; }
        public ICollection<EntityAttribute> Attributes { get; set; }
        public Guid ParentId { get; set; }
    }
}