using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Entity
{
    public class MioCategoryStateChenges
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public string? CreateBy { get; set; }
        public string? ReviewerComments { get; set;}
        public string? AttachedFile { get; set;}
    }
}
