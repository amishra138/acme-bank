using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acme.Account.Core.Models
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
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
