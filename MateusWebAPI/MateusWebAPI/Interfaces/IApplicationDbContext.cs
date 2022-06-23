using MateusWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MateusWebAPI.Interfaces
{
    public interface IApplicationDbContext 
    {
        public int Save();

        public DbSet<Product> product { get; set; }
    }
}
