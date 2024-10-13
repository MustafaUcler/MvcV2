using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcV2.Models;

namespace MvcV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Inkomst> Inkomster { get; set; }
        public DbSet<Utgift> Utgifter { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
