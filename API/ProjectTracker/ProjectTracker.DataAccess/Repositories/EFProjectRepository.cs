using Microsoft.EntityFrameworkCore;
using ProjectTracker.DataAccess.Data;
using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public class EFProjectRepository : IProjectRepository
    {
        private readonly ProjectTrackerDbContext dbContext;

        public EFProjectRepository(ProjectTrackerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(Project entity)
        {
            await dbContext.Projects.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Project entity)
        {
            dbContext.Projects.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var deletingProject = dbContext.Projects.FirstOrDefault(p => p.Id == id);
            await Delete(deletingProject);
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await dbContext.Projects.Include(x=>x.Tasks).ToListAsync();
        }

        public async Task<Project> GetById(int id)
        {

            return await dbContext.Projects.AsNoTracking().FirstAsync(x => x.Id == id);
        }

        public async Task<bool> IsExists(int id)
        {
            return await dbContext.Projects.AnyAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Project>> SearchProjectsByCategoryId(int id)
        {
            return await dbContext.Projects.AsNoTracking().Where(p => p.CategoryId == id).ToListAsync();
        }

        public async Task<IEnumerable<Project>> SearchProjectsByCategoryName(string name)
        {
            return await dbContext.Projects.Include(p => p.Category).AsNoTracking().Where(p => p.Category.Name.Contains(name)).ToListAsync();
        }

        public async Task<IEnumerable<Project>> SearchProjectsByName(string name)
        {
            return await dbContext.Projects.AsNoTracking().Where(p => p.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task Update(Project entity)
        {

            dbContext.Projects.Update(entity);
            await dbContext.SaveChangesAsync();


        }
    }
}
