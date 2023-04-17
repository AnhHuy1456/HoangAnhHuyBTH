using System.Net.Mime;
using HoangAnhHuyBTH.Models;
using Microsoft.EntityFrameworkCore;

namespace HoangAnhHuyBTH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set; }
    }
}