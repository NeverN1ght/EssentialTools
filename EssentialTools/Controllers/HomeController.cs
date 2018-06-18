using System.Web.Mvc;
using EssentialTools.Models;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private readonly IValueCalculator _calc;

        public HomeController(IValueCalculator calc, IValueCalculator calc2)
        {
            _calc = calc;
        }

        private Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };

        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(_calc) {Products = products};
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}