using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Entity.Logger
{
    public class Logger
    {
        public int Id { get; set; }
        public int LogLevel { get; set; }
        public string? Message { get; set; }
        public string? Exeption { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
