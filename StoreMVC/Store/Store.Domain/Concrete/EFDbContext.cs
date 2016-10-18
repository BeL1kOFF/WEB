using Store.Domain.Entities;
using System.Data.Entity;

namespace Store.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}