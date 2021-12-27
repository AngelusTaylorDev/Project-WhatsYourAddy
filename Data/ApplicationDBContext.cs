// Using Entity Framework Core
using Microsoft.EntityFrameworkCore;
using WhatsYourAddy.Models;

namespace WhatsYourAddy.Data
{
    // Using The DB Context Class
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
