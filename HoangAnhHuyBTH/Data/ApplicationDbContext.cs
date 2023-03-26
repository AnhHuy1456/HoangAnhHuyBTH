namespace HoangAnhHuyBTH.Data
{
    public class ApplicationDbContext : ApplicationDbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<Student> Students {get; set;}
    }
}