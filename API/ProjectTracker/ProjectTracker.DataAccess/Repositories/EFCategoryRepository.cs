using Microsoft.EntityFrameworkCore;
using ProjectTracker.DataAccess.Data;
using ProjectTracker.Domain;

namespace ProjectTracker.DataAccess.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly ProjectTrackerDbContext dbContext;

        public EFCategoryRepository(ProjectTrackerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Category entity)
        {
            await dbContext.Categories.AddAsync(entity);
            await dbContext.SaveChangesAsync();


        }

        public async Task Delete(Category entity)
        {
            dbContext.Categories.Remove(entity);
            await dbContext.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var category = dbContext.Categories.FirstOrDefault(x => x.Id == id);
            await Delete(category);

        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await dbContext.Categories.AsNoTracking().ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> IsExists(int id)
        {
            return await dbContext.Categories.AnyAsync(c => c.Id == id);
        }

        public async Task Update(Category entity)
        {
            dbContext.Categories.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
