using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{
    //binds everything in class
    //gets data
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        //_context is stuck at null
        private readonly  ApplicationDBContext _context;
        //constructor dependency injection
        public CheckoutModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            //database
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = this.PizzaName;
            pizzaOrder.BasePrice = this.PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}
