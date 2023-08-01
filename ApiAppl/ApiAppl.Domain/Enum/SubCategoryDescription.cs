using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Enum
{
    public enum SubCategoryDescription
    {
        None = 0,
        [Display (Name = "Неполная семья")]
        IncompleteFamily = 1,
        [Display(Name = "Многодетные семьи")]
        LargeFamily = 2,
        [Display(Name = "Семьи растящие детей инвалидов")]
        Disabled = 3,


    }
}
