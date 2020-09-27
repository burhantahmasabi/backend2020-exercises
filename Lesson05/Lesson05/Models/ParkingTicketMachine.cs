using System;
using System.ComponentModel.DataAnnotations;

namespace Lesson05.Models
{
    public class ParkingTicketMachine
    {
        private int minutesPrKr = 3;

        public int AmountInserted { get; private set; } = 0;

        [Display(Name = "Time now")]
        public DateTime TimeNow { get { return DateTime.Now; } }

        [Display(Name = "Paid until")]
        public DateTime PaidUntil { get { return TimeNow.AddMinutes(minutesPrKr * AmountInserted); } }

        //[Display(Name = "Info display")]
        //public string Info { get; set; } = "";


        public int[] GetCoinsToInsert()
        {
            return new int[] { 1, 2, 5, 10, 20 };
        }

        public void InsertCoin(int amount)
        {
            AmountInserted += amount;
        }
    }
}
