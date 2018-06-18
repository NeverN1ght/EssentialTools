using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private readonly IDiscountHelper _discounter;
        private static int counter = 0;
        public LinqValueCalculator(IDiscountHelper discounter)
        {
            _discounter = discounter;

            System.Diagnostics.Debug.WriteLine(
                string.Format("Instance {0} created", ++counter));
        }

        public decimal ValueProducts(IEnumerable<Product> product)
        {
            return _discounter.ApplyDiscount(product.Sum(p => p.Price));
        }
    }
}