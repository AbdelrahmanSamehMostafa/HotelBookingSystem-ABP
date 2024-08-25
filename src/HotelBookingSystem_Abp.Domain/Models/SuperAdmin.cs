using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookingSystem.Models
{
    public class SuperAdmin : AuditedEntity<int>
    {
        public string Name { get; set; } = "admin";

        public string Password { get; set; } = "admin";
    }
}
