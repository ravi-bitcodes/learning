namespace AzureLearnWebApp.Services.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        public List<TEntity> GetAll();
        public TEntity GetByCode(string id);
    }
}
