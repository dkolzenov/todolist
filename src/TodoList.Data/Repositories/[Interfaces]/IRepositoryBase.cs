namespace TodoList.Data.Repositories.Interfaces
{
    using System.Linq.Expressions;

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();

        Task<bool> AddAsync(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity);

        Task<bool> RemoveAsync(TEntity entity);

        Task<List<TEntity>> QueryAsync(
            params Expression<Func<TEntity, bool>>[] predicates);
    }
}
