using Microsoft.EntityFrameworkCore;

namespace CarrosCRUDRazor.Models
{
    public class CarroContext : DbContext
    {
        public CarroContext(DbContextOptions<CarroContext> options)
        : base(options)
        {
            //default
        }
        public DbSet<Carro> Carro { get; set; }
        
    }
}