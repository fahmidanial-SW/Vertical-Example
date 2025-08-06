using Vertical_Example.Entity;
using Microsoft.EntityFrameworkCore;

namespace Vertical_Example.Data
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;

    }
}
