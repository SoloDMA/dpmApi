using Microsoft.EntityFrameworkCore;
using DAL.Entities;

namespace DAL.DpmContext
{
    public class DpmContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<DevelopmentPlan> DevelopmentPlans { get; set; }
        public DbSet<Competence> Competences { get; set; }

        public DpmContext(DbContextOptions<DpmContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
