using ApiAppl.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Entity
{
    public class BoProgramm
    {
        public int Id { get; set; }
        public SubCategoryDescription SubCategoryDescription { get; set; }
        public QueueStatus QueueStatus { get; set; }
    }
}
