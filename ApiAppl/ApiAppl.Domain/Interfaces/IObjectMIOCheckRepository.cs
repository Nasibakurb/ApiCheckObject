using ApiAppl.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Domain.Interfaces
{
    public interface IObjectMIOCheckRepository
    {
        IEnumerable<ObjectsMIOCheck> GetAllMIOObjects(); // Выдать все элементы
        Task CreateMIOObject(ObjectsMIOCheck objectsMIOCheck); // Создать
        ObjectsMIOCheck GetById(int id); // Брать по id
        void Update(ObjectsMIOCheck objectsMIOCheck); // Обновить для редактирование
        void SaveChanges(); // Сохранение
        Task<IEnumerable<string>> GetForActualObject();

    }
}
