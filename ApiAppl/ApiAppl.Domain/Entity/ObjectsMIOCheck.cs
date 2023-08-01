
using ApiAppl.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace ApiAppl.Domain.Entity
{
    public class ObjectsMIOCheck
    {
        public int Id { get; set; }
        [Required]
        public string CodeObject { get; set; }
        public DateTime CreateDate { get; set; }
        public Status StatusName { get; set; }
        public int CategoryId { get; set; }


    }

}
