using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingSystem_Abp.Exceptions
{
    public class EntityAlreadyExistsException : Exception
    {
        public EntityAlreadyExistsException(Type entityType, string message)
                   : base($"Entity '{entityType.Name}' already exists. {message}")
        {
        }
    }
}