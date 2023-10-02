namespace CarApp.Data
{
    public class DatabaseContext:DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<CarModel> Cars { get; set; }

    }
}
