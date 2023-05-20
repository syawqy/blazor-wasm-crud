using BlazorWebCRUD.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebCRUD.Server.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
