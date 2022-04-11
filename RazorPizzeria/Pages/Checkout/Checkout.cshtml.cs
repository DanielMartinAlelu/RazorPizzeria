using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice {get; set; }
        public string ImageTitle { get; set; }


        //Necesitamos hacer Dependency injection (importante), tenemos que crear un constructor
        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            //Creamos una nueva pizza con la base de datos (No necesitamos poner el Id porque la db ya lo crea solo)
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            //Necesitamos 2 metodos para add a la db
            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();   //Siempre que modifiques la db, guardar cambios
        }
    }
}
