using System.Net.Mime;
using BTH1004.Models;
using Microsoft.EntityFrameworkCore;

namespace BTH1004.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BTH1004.Models.Faculty> Facultys { get; set; } = default!;
        
        public DbSet<BTH1004.Models.Student> Student { get; set; } = default!;
    
        public DbSet<BTH1004.Models.Employee> Employee  { get; set; } 
    }
}