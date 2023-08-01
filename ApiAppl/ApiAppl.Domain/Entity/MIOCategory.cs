using ApiAppl.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Entity
{
    public class MIOCategory
    {
       public int Id { get; set; }
       [Required]
       public string Name { get; set; }
        public string? SubName { get; set; }
        public Boprogramm Boprogramm { get; set; } 
        public string? Created { get ; set; }
        public string? LastChange { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateChange { get; set; }
        public Status StatusNameCategory { get; set; }


    }
}
