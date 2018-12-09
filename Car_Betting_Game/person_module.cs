using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Car_Betting_Game
{
   public class person_module
    {
        public string Name;
        public int Money;
        public bet_module Bet;

        //person's gui controls
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            //set the label to my bet's description and label on radio button to show money
            MyLabel.Text = this.Bet.GetDescription();//"Bets $"+Bet.Amount + " on car " + (Bet.Car +1);
        }

        public void ClearBet()
        {
            //reset my bet so it's zero
        }

        public bool PlaceBet(int BetAmount, int CarToWin)
        {
            //Place a new bet and store it
            //return true if person had enough money to bet
            if (this.Money >= BetAmount)
            {
                Bet = new bet_module()
                {
                    Amount = BetAmount,
                    Car = CarToWin,
                    Bettor = this//Amount = numBets.Value, Bettor = Name, Car = numCar.Value -1
                };

                UpdateLabels();

                Console.WriteLine(this.Name + " had enough to bet");
                return true;
            }
            else
            {


                MessageBox.Show(this.Name + " didn't have enough to bet");
                // Console.WriteLine(this.Name + " didn't have enough to bet");
                return false;
            }
        }

        public void Collect(int num)
        {
            //ask my bet to pay out, clear my bet, and update my labels
        }
    }
}
