using ExamplApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ExamplApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        { 
        }
        public DbSet<Product> Products { get; set; } = null!;


    }
}
