namespace TodoList.Data.Repositories.Interfaces
{
    using System.Linq.Expressions;

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> RemoveAsync(TEntity entity);

        Task<List<TEntity>> QueryAsync(
            params Expression<Func<TEntity, bool>>[] predicates);
    }
}
