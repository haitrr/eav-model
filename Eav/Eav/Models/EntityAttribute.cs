namespace Eav.Models
{
    public class EntityAttribute : DatabaseObject
    {
        public Entity Entity { get; set; }
        public AttributeType Type { get; set; }
        public AttributeValue Value { get; set; }

    }
}