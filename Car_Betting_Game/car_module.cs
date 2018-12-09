using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;


namespace Car_Betting_Game
{
   public class car_module
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run(PictureBox racetrack)
        {
            //move forward either 1, 2, 3, or 4 spaces at random
            this.MyPictureBox.Left += this.Randomizer.Next(2, 7);
            //update the position of my picturebox on the form
            //MyPictureBox.Left = StartingPosition + Location;
            //return true if I won the race
            if (this.MyPictureBox.Right > racetrack.Right)
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            //reset location to 0 and picturebox to starting position
            Location = 0;
            StartingPosition = 0;
        }

    }
}
