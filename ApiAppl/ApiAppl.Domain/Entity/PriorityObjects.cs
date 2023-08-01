using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Entity
{
    public class PriorityObjects
    {
        public int Id { get; set; }
        public int PnObjectId { get; set; }
        public int PnStatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public string? ReviewerComments { get; set; }

        public Pn_Object? Pn_Object { get; set; }
        public PnStatus? PnStatus { get; set; }

    }
}
