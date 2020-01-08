using Microsoft.EntityFrameworkCore;
using DatingApp.Model;
namespace DatingApp.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Values>().ToTable("Value");
            
        }
        public DbSet<Values> Values{ get; set; }


        
    }
}