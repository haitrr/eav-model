namespace Eav.Models
{
    public class AttributeValue : DatabaseObject
    {
        public EntityAttribute Attribute { get; set; }
        public dynamic Value { get; set; }
    }
}