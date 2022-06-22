using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaApp.Data;
using RazorPizzaApp.Models;

namespace RazorPizzaApp.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> Orders { get; set; }

        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Orders = _context.PizzaOrders.ToList();

        }
    }
}
