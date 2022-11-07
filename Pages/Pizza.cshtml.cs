using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {ImageTitle="Margerita",
             PizzaName = "Margerita",
             BasePrice = 2,
             TomatoSauce= true,
             Cheese=true,
             FinalPrice = 5},

            new PizzasModel()
            {
                ImageTitle= "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Pepperoni = true,
                FinalPrice = 5
            },

            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PizzaName = "Meat Feast",
                BasePrice = 3,
                TomatoSauce = true,
                Cheese = true,
                Pepperoni = true,
                Ham = true,
                Beef = true,
                FinalPrice=5
            },

            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian Pizza",
                BasePrice = 20,
                TomatoSauce = true,
                Cheese = true, 
                Ham = true,
                Pineapple = true,
                FinalPrice = 20
            },

            new PizzasModel()
            {
                ImageTitle = "Seafood",
                PizzaName = "Seafood Pizza",
                BasePrice = 5,
                TomatoSauce = true,
                Cheese = true,
                Tuna = true,
                FinalPrice = 5
            }
        };
        public void OnGet()
        {

        }
    }
}
