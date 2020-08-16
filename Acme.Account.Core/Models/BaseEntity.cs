using System;

namespace Acme.Account.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }

        public string CreatedByUserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public int ModifiedBy { get; set; }

        public string ModifiedByUsername { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
