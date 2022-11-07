using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {

        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

        //dependency injection constructor
        private readonly ApplicationDBContext _context;

        public OrdersModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            //takes pizza orders to list from data base
            PizzaOrders = _context.PizzaOrders.ToList();


        }
    }
}
