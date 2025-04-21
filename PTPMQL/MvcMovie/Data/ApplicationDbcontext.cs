using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    using Microsoft.EntityFrameworkCore;
    using MvcMovie.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Person { get; set;}
        public DbSet<MvcMovie.Models.Employee> Employee { get; set; } = default!;
    }
}