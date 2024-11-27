using ECommerceWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceWebApp.Services
{
    public class CartService
    {
        private readonly List<Product> cartItems = new();

        public IEnumerable<Product> GetCartItems()
        {
            return cartItems;
        }

        public void AddToCart(Product product)
        {
            cartItems.Add(product);
        }

        public void RemoveFromCart(Product product)
        {
            cartItems.Remove(product);
        }

        public double GetTotalPrice()
        {
            return cartItems.Sum(p => p.Price);
        }

        public void ClearCart()
        {
            cartItems.Clear();
        }
    }
}
