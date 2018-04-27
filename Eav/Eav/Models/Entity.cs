using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Emit;

namespace Eav.Models
{
    public class Entity : DatabaseObject
    {
        public Guid EntityTypeId { get; set; }
        public ICollection<AttributeValue> Properties { get; set; }
        public bool IsRemoved { get; set; }
    }
}
