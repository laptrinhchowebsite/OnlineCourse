using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ProductCategory
    {
        public long ID { get; set; }
        public string MetaTitle { get; set; }
        public Nullable<long> ParentID { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> ShowOnHome { get; set; }
    }
}
