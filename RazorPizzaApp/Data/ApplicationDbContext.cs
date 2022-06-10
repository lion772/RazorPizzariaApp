using Microsoft.EntityFrameworkCore;
using RazorPizzaApp.Models;

namespace RazorPizzaApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}
