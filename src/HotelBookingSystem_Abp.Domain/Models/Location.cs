using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace BookingSystem.Models
{
    public class Location : ValueObject
    {
        public string Name { get; }

        public Location(string name)
        {
            Name = name;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
        }
    }
}
