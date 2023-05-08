using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Phonebook.Models
{
    public class ContactDbContext : IdentityDbContext 
    {
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public ContactDbContext() { }

        public ContactDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}