using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class OrderItem
    {
        public int OrderItemId;
        public int ProductId;
        public Product Product;
        public int Quantity;
        public decimal TotalPrice { get { return Quantity * Product.Price; } }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;

        }
    }
}