using System;
using System.Collections.Generic;
using System.Text;

namespace TidePortal.Service
{
    public class FullEntityDto : BaseEntityDto
    {
        public DateTime CreateTime { get; set; }
        public int CreatorId { get; set; }
        public DateTime? LastModifyTime { get; set; }
        public int? LastModifierId { get; set; }
    }
}
