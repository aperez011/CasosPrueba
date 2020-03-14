using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Entity
{
    public class Field : EntityBase
    {
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public Guid ValueType { get; set; }
        public string Size { get; set; }
        public Guid BoundedLevel { get; set; }
        public int MinOccurs { get; set; }
        public int MaxOccurs { get; set; }
        public int Order { get; set; }
        public bool IsCalculated { get; set; }
        public string Formula { get; set; }
    }
}
