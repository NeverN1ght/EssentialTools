using System.Collections.Generic;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        private readonly IValueCalculator _calc;
        public ShoppingCart(IValueCalculator calc)
        {
            _calc = calc;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return _calc.ValueProducts(Products);
        }
    }
}