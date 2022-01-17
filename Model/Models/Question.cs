using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Question
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Answer { get; set; }
        public string Type { get; set; }
        public Nullable<long> ProductID { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
