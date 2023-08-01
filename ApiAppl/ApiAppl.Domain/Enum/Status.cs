using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Enum
{
    public enum Status
    {
        [Display(Name = "Принято")]
        Accepted = 1,
        [Display(Name = "Анулировано")]
        Canceled = 2
    }
}
