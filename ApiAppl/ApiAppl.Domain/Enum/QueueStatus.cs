using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Enum
{
    public enum QueueStatus
    {
        [Display(Name = "Прошел")]
        Pass = 1,
        [Display(Name = "Не прошел")]
        NoPass = 2,
    }
}
