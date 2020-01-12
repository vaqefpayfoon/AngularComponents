using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace restAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option) {}
           
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}