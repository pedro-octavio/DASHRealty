using DASHRealty.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DASHRealty.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Property> Properties { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
