using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {

        public DataContext (DbContextOptions<DataContext> option) : base(option) { }        

        public DbSet<User> Users { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        
    }
}