using AdminLTE.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE.Data
{
    public class ApplicationDbContext : AuditableIdentityContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }



    }
}
