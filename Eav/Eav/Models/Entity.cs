using System.Collections.Generic;

namespace Eav.Models
{
    public class Entity : DatabaseObject
    {
        public EntityType Type { get; set; }
        public ICollection<EntityAttribute> Attributes { get; set; }
        public ICollection<Relationship> Relationships { get; set; }
        public bool IsRemoved { get; set; }
    }
}
