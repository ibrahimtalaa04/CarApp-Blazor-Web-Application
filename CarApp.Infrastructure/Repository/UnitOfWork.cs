namespace CarApp.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext _db;

        public UnitOfWork(DatabaseContext db)
        {
            _db = db;
            CarRepository = new CarRepository(_db);
        }

        public ICarRepository CarRepository { get; set; }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> CreateTransaction()
        {
            return await _db.Database.BeginTransactionAsync();
        }

        public async Task Rollback(IDbContextTransaction transaction)
        {
            await transaction.RollbackAsync();
        }
        public async Task Commit(IDbContextTransaction transaction)
        {
            await transaction.CommitAsync();
        }

    }
}
