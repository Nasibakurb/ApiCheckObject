using ApiAppl.Domain.Entity;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Interfaces
{
    public interface IMIOCategoryRepository
    {
        IEnumerable<MIOCategory> GetAllCategories(); // Получить все

        Task CreateCategory(MIOCategory mioCategory); // Создать

        Task<MIOCategory> GetCategoryById(int id); // Получить по id
        void UpdateCategory(MIOCategory mioCategory); // Обновить (для редактирование)
        Task SaveChanges(); // Сохранить

    }
}
