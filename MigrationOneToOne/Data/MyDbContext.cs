using Microsoft.EntityFrameworkCore;
using MigrationOneToOne.Models;

namespace MigrationOneToOne.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Child>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Parent>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Parent>()
                .HasOne( c => c.Child)
                .WithMany()
                .HasForeignKey(p => p.ChildId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
