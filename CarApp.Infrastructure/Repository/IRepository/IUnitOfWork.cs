namespace CarApp.Infrastructure.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICarRepository CarRepository{ get; }

        Task Save();

        Task<IDbContextTransaction> CreateTransaction();
        Task Rollback(IDbContextTransaction transaction);
        Task Commit(IDbContextTransaction transaction);
    }
}
