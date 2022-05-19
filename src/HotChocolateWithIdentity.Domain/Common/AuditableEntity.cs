using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolateWithIdentity.Domain.Common
{
    public abstract class AuditableEntity
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedUtc { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedUtc { get; set; }
    }
}
