using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingSystem_Abp.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public Type EntityType { get; }
        public object EntityId { get; }

        public EntityNotFoundException(Type entityType, object entityId)
            : base($"Entity '{entityType.Name}' with ID '{entityId}' was not found.")
        {
            EntityType = entityType;
            EntityId = entityId;
        }

        public EntityNotFoundException(Type entityType, object entityId, string message)
            : base(message)
        {
            EntityType = entityType;
            EntityId = entityId;
        }
    }
}
