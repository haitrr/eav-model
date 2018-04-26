using System;

namespace Eav.Models
{
    public class Relationship
    {
        public Guid Id { get; set; }
        public Entity EntityOne { get; set; }
        public Entity EntityTwo { get; set; }
        public RelationshipType Type { get; set; }
    }
}