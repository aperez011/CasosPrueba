using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Entity
{
    public class SubSection : EntityBase
    {
        public Guid SectionId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
