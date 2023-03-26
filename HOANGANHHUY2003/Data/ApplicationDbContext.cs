using System.Net.Mime;
using HOANGANHHUY2003.Models;
using Microsoft.EntityFrameworkCore;

namespace HOANGANHHUY2003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set; }
    }
}