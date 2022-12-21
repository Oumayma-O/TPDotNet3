using Microsoft.EntityFrameworkCore;

namespace TP33.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<DbContext> Miniatures { get; set; }
        //that's gonna be the name of the table in the database 
    }
}
