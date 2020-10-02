using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CP.Entity
{
    public class Section : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Order { get; set; }
    }
}
