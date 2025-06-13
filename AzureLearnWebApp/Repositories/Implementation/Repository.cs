using AzureLearnWebApp.Models;
using AzureLearnWebApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AzureLearnWebApp.Repositories.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AzureProdContext _dbContext;
        public Repository(AzureProdContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetByCode(string id)
        {
            return _dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefault(e => EF.Property<string>(e, "Id") == id);
        }
    }
}
