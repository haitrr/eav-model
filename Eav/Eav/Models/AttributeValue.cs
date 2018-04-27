using System;

namespace Eav.Models
{
    public class AttributeValue : DatabaseObject
    {
        public Guid EntityAttributeId { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
    }
}