using AzureLearnWebApp.Repositories.Interfaces;
using AzureLearnWebApp.Services.Interfaces;

namespace AzureLearnWebApp.Services.Implementations
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        IRepository<TEntity> _repository;
        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetByCode(string id)
        {
            return _repository.GetByCode(id);
        }
    }
}
