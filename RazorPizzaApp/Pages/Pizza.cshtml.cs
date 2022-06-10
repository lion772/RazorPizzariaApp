using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaApp.Models;

namespace RazorPizzaApp.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=3, TomatoSauce=true, Cheese=true, Beef=true, FinalPrice=3},
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=3, TomatoSauce=true, Cheese=true, Pineapple=true, FinalPrice=10},
            new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=3, TomatoSauce=true, Cheese=true, Mushroom=true, FinalPrice=5},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=3, TomatoSauce=true, Cheese=true, Pineapple=true, FinalPrice=4},
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=3, TomatoSauce=true, Cheese=true, Tuna=true, FinalPrice=4},
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=3, TomatoSauce=true, Cheese=true, FinalPrice=8},
            new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=3, TomatoSauce=true, Cheese=true, FinalPrice=7},
            new PizzasModel(){ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=3, TomatoSauce=true, Cheese=true, Ham=true, FinalPrice=7},
        };

        public void OnGet()
        {
        }
    }
}
