using ApiAppl.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Interfaces
{
    public interface IMIOCategoryService
    {
        IEnumerable<MIOCategory> GetAllMIOCategories(); // Получить все

        Task<MIOCategory> CreateMIOCategory(MIOCategory mioCategory); // Создать
        Task UpdateMIOCategory(int id, MIOCategory updatedMIOCategory); // Редактировать
        Task ChangeStatus(int id); // Изменить статус
    }
}
