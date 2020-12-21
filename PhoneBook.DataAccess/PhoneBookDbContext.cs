using Microsoft.EntityFrameworkCore;
using PhoneBook.DataAccess.Models;

namespace PhoneBook.DataAccess
{
    public class PhoneBookDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=91.201.72.213;Database=PhoneBookGuk;User=study;Password=study;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(b =>
            {
                b.Property(p => p.Surname)
                    .HasMaxLength(50)
                    .IsRequired();

                b.Property(p => p.Name)
                    .HasMaxLength(50)
                    .IsRequired();

                b.Property(p => p.PhoneNumber)
                    .HasMaxLength(20)
                    .IsRequired();
            });
        }
    }
}
