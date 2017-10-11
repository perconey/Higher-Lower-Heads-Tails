using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST___2___HigherLower_HeadsTails.Logic
{
    class HeadsOrTails
    {

        private int _sideOfCoin;
        public int SideOfCoin { get => _sideOfCoin; set => _sideOfCoin = value; }

        public HeadsOrTails()
        {
            // 0 is heads
            // 1 is tails
            _sideOfCoin = HiLow.RandomNumber(0, 2);
        }

        public bool CheckIfGuessed(int guess)
        {
            if (guess == SideOfCoin)
            {
                Console.WriteLine("Congratulations, you've guessed");
                return true;
            }
            else return false;
        }
    }
}
