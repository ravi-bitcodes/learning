
namespace AzureLearnWebApp.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public List<TEntity> GetAll();

        public TEntity GetByCode(string id);
    }
}
