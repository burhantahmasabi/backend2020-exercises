using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson05.Models
{
    public class BreakfastFood
    {
        public int BreakfastFoodId {get; set;}
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public bool Selected { get; set; }
    }
}
