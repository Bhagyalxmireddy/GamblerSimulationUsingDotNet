using System;

namespace GamblerSimulation
{
    class Program
    {
        public const int STAKE = 100;
        public const int BET = 1;
        int stakeValue;
        int result;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GamblerSimulation program");
            Program gambler = new Program();
            gambler.gamblerGame();
        }
        public  int gamblerGame()
        {
            Random random = new Random();
            int bettingToss = random.Next(0, 2);
            if(bettingToss == 1)
            {
                stakeValue = STAKE + BET;
                Console.WriteLine("Gambler Won the Game" + stakeValue);
            }
            else
            {
                stakeValue = STAKE - BET;
                Console.WriteLine("Gambler loss the Game" + stakeValue);
            }
            return result;
        }
    }
}
