using Microsoft.EntityFrameworkCore;
using MvcDbproject.Models;

namespace MvcDbproject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; } 
    }
}
