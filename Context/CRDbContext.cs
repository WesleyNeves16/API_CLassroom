using Microsoft.EntityFrameworkCore;

namespace ClassroomRegistration.Context
{
    public class CRDbContext : DbContext
    {
        public CRDbContext() : base()
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Prova> Prova { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"");
            base.OnConfiguring(builder);
        }
    }
}
