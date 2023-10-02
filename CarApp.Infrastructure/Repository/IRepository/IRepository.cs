namespace CarApp.Infrastructure.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true);
        IQueryable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        Task Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
