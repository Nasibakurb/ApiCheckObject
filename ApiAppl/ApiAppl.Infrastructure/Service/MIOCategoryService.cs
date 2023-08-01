using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Enum;
using ApiAppl.Domain.Interfaces;

namespace ApiAppl.Infrastructure.Service
{
    public class MIOCategoryService: IMIOCategoryService
    {
        private readonly IMIOCategoryRepository _repository;

        public MIOCategoryService(IMIOCategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task ChangeStatus(int id)
        {
            var mioCategory = await _repository.GetCategoryById(id);
            if (mioCategory == null)
            {
                throw new InvalidOperationException("ObjectMIOCheck not found");
            }

            mioCategory.StatusNameCategory = mioCategory.StatusNameCategory == Status.Canceled ? Status.Accepted : Status.Canceled;

            await _repository.SaveChanges();
        }


        public async Task<MIOCategory> CreateMIOCategory(MIOCategory mioCategory)
        {
            mioCategory.DateCreated = DateTime.Now;
            mioCategory.StatusNameCategory = Status.Accepted;
            await _repository.CreateCategory(mioCategory);
            return mioCategory;
        }

        public IEnumerable<MIOCategory> GetAllMIOCategories()
        {
            return _repository.GetAllCategories();
        }

        public async Task UpdateMIOCategory(int id, MIOCategory updatedMIOCategory)
        {
            var mioCategory = await _repository.GetCategoryById(id);
            if (mioCategory == null)
            {
                throw new InvalidOperationException("Category not found");
            }

            mioCategory.Name = updatedMIOCategory.Name;
            mioCategory.SubName = updatedMIOCategory.SubName;
            mioCategory.LastChange = updatedMIOCategory.LastChange;
            mioCategory.DateChange = DateTime.Now;
            mioCategory.Boprogramm = updatedMIOCategory.Boprogramm;


            _repository.UpdateCategory(mioCategory);
            await _repository.SaveChanges();
        }
    }
}
