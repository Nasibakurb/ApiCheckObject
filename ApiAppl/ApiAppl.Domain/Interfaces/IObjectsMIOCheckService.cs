using ApiAppl.Domain.Entity;


namespace ApiAppl.Domain.Interfaces
{
    public interface IObjectsMIOCheckService
    {
        IEnumerable<ObjectsMIOCheck> GetAllMIOObjects();
        Task<ObjectsMIOCheck> CreateMIOObject(ObjectsMIOCheck objectsMIOCheck);
        void ChangeStatus(int id);
        Task<IEnumerable<string>> GetForActualObject();

        //void UpdateMIOCheck(int id, ObjectsMIOCheck updateObjectsMIOCheck);
    }
}
