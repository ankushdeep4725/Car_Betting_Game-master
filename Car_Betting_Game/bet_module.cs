using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Betting_Game
{
   public class bet_module
    {
        public int Amount;
        public int Car;
        public person_module Bettor;





        public string GetDescription()
        {
            //return a string that say who placed the bet, how much cash was bet, and which car he bet on. 
            //If amount is zero no bet is placed
            string desc = Bettor.Name + " bet $" + this.Amount + " on Car " + (this.Car + 1);
            return desc;
        }

        public int PayOut(int Winner)
        {
            //parameter is winner of race. if the car won, return the amount bet
            //otherwise, return the negative of the amount bet
            if (Winner == this.Car)
            {
                return this.Amount;
            }
            else
            {
                return -1 * this.Amount;
            }
        }
    }
}
