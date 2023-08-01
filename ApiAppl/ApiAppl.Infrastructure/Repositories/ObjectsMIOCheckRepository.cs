 using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Enum;
using ApiAppl.Domain.Interfaces;
using ApiAppl.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiAppl.DAL.Repositories
{
    public class ObjectsMIOCheckRepository : IObjectMIOCheckRepository
    {
        private readonly AppDbContext _context;

        public ObjectsMIOCheckRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ObjectsMIOCheck> GetAllMIOObjects()
        {
            return _context.ObjectsChecks.ToList();
        }

        public ObjectsMIOCheck GetById(int id)
        {
            return _context.ObjectsChecks.FirstOrDefault(o => o.Id == id);
        }

        public void Update(ObjectsMIOCheck objectsMIOCheck)
        {
            _context.Entry(objectsMIOCheck).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public async Task<Pn_Object> GetPnObjectByCode(long code)
        {
            return await _context.Pn_Objects.FirstOrDefaultAsync(p => p.Code == code);
        }

        public async Task CreateMIOObject(ObjectsMIOCheck objectsMIOCheck)
        {
            _context.ObjectsChecks.Add(objectsMIOCheck);
            await _context.SaveChangesAsync();
        }

        public async Task<Pn_Object> GetByCode(long code)
        {
            return await _context.Pn_Objects.FindAsync(code);
        }

        public async Task<IEnumerable<string>> GetForActualObject()
        {
            var categories = await _context.MIOCategories
                .Where(c => _context.ObjectsChecks.Any(o => o.StatusName.Equals(Status.Accepted)))
                .Select(c => c.Name)
                .ToListAsync();

            return categories;
        }


        //public async Task<MIOCategory> GetCategoryById(int categoryId)
        //{
        //    return await _context.MIOCategories.FindAsync(categoryId);
        //}
    }
}
