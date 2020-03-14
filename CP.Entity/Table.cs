using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Entity
{
    public class Table : EntityBase
    {
        public Guid OwnerId { get; set; }
        public string TableName { get; set; }
        public string ListName { get; set; }
        public int Order { get; set; }
        public Guid BoundedLevel { get; set; }
        public int MinOccurs { get; set; }
        public int MaxOccurs { get; set; }
    }
}
