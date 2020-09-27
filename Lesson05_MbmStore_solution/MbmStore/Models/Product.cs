using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models {

    public class Product {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }


        // constructor
        public Product() { }

        // constructor
        public Product(string title, decimal price) {
            Title = title;
            Price = price;
        }
    }
}