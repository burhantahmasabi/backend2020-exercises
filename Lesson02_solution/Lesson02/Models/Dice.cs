using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson02.Models {

    public class Dice {

        private int eyes;
        
        //private int numRolls;
        //public int NumRolls
        //{
        //    get { return numRolls; }
        //}

        public int NumRolls { get; set; }
        public int Outcome { get; set; }
        public int TotalSum { get; set; }
        public int[] Distribution { get; set; }
        
        public Dice() {
            eyes = 6;
            NumRolls = 0;
            TotalSum = 0;
            Distribution = new int[eyes];
        }

        public void Roll() {
            Random randNum = new Random();
            Outcome = randNum.Next(1, eyes+1);
            NumRolls++;
            TotalSum += Outcome;
            Distribution[Outcome-1]++;
        }
    }
}