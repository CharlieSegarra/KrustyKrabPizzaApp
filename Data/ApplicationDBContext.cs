using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    public class ApplicationDBContext : DbContext
    {
        //table in sql database
        public DbSet <PizzaOrder> PizzaOrders { get; set; }

        //constructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
    }
}
