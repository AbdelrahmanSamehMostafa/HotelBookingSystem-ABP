using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookingSystem.Models
{
    public class PendingReq : AuditedEntity<Guid>
    {
        public Guid SuperAdminID { get; set; }

        public Guid AdminID { get; set; }
    }
}
