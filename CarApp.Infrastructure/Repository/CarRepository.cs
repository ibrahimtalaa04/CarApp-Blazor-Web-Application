namespace CarApp.Infrastructure.Repository
{
    public class CarRepository : Repository<CarModel>, ICarRepository
    {
        private readonly DatabaseContext _db;

        public CarRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }
    }
}
