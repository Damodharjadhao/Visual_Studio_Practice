using Microsoft.EntityFrameworkCore;

namespace EF_Practice.modal
{
    public class DataContext : DbContext
    {
        //CONSTRUCTOR
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<DbClass> superheroes { get; set; }
    }
}
