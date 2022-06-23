using MateusWebAPI.Interfaces;
using MateusWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MateusWebAPI.Data
{
    public class ApplicationMySqlDbContext : DbContext, IApplicationDbContext
    {
        private IConfiguration _configuration { get; set; }

        public ApplicationMySqlDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_configuration.GetConnectionString("DefaultConnection"),
                      ServerVersion.AutoDetect(_configuration.GetConnectionString("DefaultConnection")));
        }

        public DbSet<Product> product { get; set; }
        
        public int Save() 
        { 
            return SaveChanges();
        }
    }
}
