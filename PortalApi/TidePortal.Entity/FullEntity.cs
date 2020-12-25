using System;
using System.Collections.Generic;
using System.Text;

namespace TidePortal.Entity
{
    public class FullEntity: BaseEntity
    {
        public DateTime CreateTime { get; set; }
        public int CreatorId { get; set; }
        public DateTime? LastModifyTime { get; set; }
        public int? LastModifierId { get; set; }
    }
}
