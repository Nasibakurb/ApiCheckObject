using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Interfaces;
using ApiAppl.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiAppl.DAL.Repositories
{
    public class MIOCategoryRepository: IMIOCategoryRepository
    {
        private readonly AppDbContext _context;

        public MIOCategoryRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task CreateCategory(MIOCategory mioCategory)
        {
            _context.MIOCategories.Add(mioCategory);
            await _context.SaveChangesAsync();
        }

      

        public IEnumerable<MIOCategory> GetAllCategories()
        {
            return _context.MIOCategories.ToList();
        }

        public async Task<MIOCategory> GetCategoryById(int id)
        {
            return await _context.MIOCategories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void UpdateCategory(MIOCategory mioCategory)
        {
            _context.Entry(mioCategory).State = EntityState.Modified;
        }

         public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
