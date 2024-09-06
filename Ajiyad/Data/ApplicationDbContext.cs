using Ajiyad.Models;
using Microsoft.EntityFrameworkCore;
//Here where i declare that this project using entity framework + here create the tables that reflect on the database 
namespace Ajiyad.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        //Building is entity
        public DbSet<Building> BuildingDetails { get; set; }
    }
}
