using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Enum;
using ApiAppl.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Net.Http.Json;

namespace ApiAppl.Infrastructure.Service
{
    public class ObjectsMIOCheckService : IObjectsMIOCheckService
    {
        private readonly IObjectMIOCheckRepository _repository;

        public ObjectsMIOCheckService(IObjectMIOCheckRepository repository)
        {
            _repository = repository;
        }

        public void ChangeStatus(int id)
        {
            var objectMIOCheck = _repository.GetById(id);
            if (objectMIOCheck == null)
            {
                throw new InvalidOperationException("ObjectMIOCheck not found");
            }

            objectMIOCheck.StatusName = objectMIOCheck.StatusName == Status.Canceled ? Status.Accepted : Status.Canceled;
            _repository.Update(objectMIOCheck);
            _repository.SaveChanges();

        }


        public async Task<ObjectsMIOCheck> CreateMIOObject(ObjectsMIOCheck objectsMIOCheck)
        {
                objectsMIOCheck.CreateDate = DateTime.Now;
                objectsMIOCheck.StatusName = Status.Accepted;

                await _repository.CreateMIOObject(objectsMIOCheck);

                return objectsMIOCheck;
        }

        public IEnumerable<ObjectsMIOCheck> GetAllMIOObjects()
        {
            return _repository.GetAllMIOObjects();
        }

       

        public async Task<IEnumerable<string>> GetForActualObject()
        {
            return await _repository.GetForActualObject();
        }


        //public void UpdateMIOCheck(int id, ObjectsMIOCheck updateObjectsMIOCheck)
        //{
        //    var objectsMIOCheck = _repository.GetById(id);
        //    if (objectsMIOCheck == null)
        //    {
        //        throw new InvalidOperationException("ObjectsMIOCheck not found");
        //    }

        //    objectsMIOCheck.RegNum = updateObjectsMIOCheck.RegNum;
        //    objectsMIOCheck.TypeName = updateObjectsMIOCheck.TypeName;
        //    objectsMIOCheck.StatusName = updateObjectsMIOCheck.StatusName;
        //    objectsMIOCheck.FullName = updateObjectsMIOCheck.FullName;
        //    objectsMIOCheck.UserId = updateObjectsMIOCheck.UserId;
        //    objectsMIOCheck.CategotyId = updateObjectsMIOCheck.CategotyId;

        //    _repository.Update(objectsMIOCheck);
        //    _repository.SaveChanges();
        //}
    }

}