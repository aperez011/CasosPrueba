using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CP.Entity
{
    public partial class EntityBase
    {
        [Key]
        public int Indx { get; set; }
        [Required]
        public Guid GID { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime LogDate { get; set; }
    }
}
