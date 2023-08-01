using ApiAppl.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Entity
{
    public class PriorityObjectHistory
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PriorityObjectId { get; set; }
        public int OldPnStatusId { get; set; }
        public int NewPnStatusId { get; set; }
        public string? ChangeUser { get; set; }
        public string? ReviewerComments { get; set; }

        public PnStatus? PnStatus { get; set; }
        public Pn_Object? Pn_Object { get; set; }

    }
}
