using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson05.Models
{
    public class BreakfastOrder
    {
        public string Fullname { get; set; }
        public int? RoomNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Delivery { get; set; } = DateTime.Now;

        public List<BreakfastFood> BreakfastFoods { get; } = new List<BreakfastFood>();

        public void AddBreakfastFood(BreakfastFood food) {
            BreakfastFoods.Add(food);
        }

    }
}
