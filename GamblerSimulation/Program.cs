using System;

namespace GamblerSimulation
{
    class Program
    {
        public const int STAKE = 100;
        public const int PERCENT = 50;
        public const int BET = 1;
        public const int DAYS = 20;
        int winning = 0;
        int lossing = 0;
        int stakeValue;
        int result;
        int winamount = 0;
        int lossamount = 0;
        int won = 0;
        int loss = 0;
        int amount;
        int days;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GamblerSimulation program");
            Program gambler = new Program();
            gambler.totalAmount_For20Days();
        }
        public int gamblerGame()
        {
            int value = (STAKE * PERCENT) / 100;
            winning = STAKE + value;
            Console.WriteLine("The Winning value of gambler is : " + winning);
            lossing = STAKE - value;
            Console.WriteLine("The Lossing value of gambler is : " + lossing);
            
            amount = 100;
            while (amount > lossing && amount < winning)
            {
                Random random = new Random();
                int bettingToss = random.Next(0, 2);
                if (bettingToss == 1)
                {
                    amount = amount + BET;
                    Console.WriteLine("Gambler Won the Game : " + amount);
                }
                else
                {
                    amount = amount - BET;
                    Console.WriteLine("Gambler loss the Game : " + amount);
                }
            }
            if (amount == 150)
            {
                winamount = winamount + amount;
                won = won + 1;
            }
            else
            {
                lossamount = amount - lossamount;
                loss = loss - 1;
            }
            Console.WriteLine("amount of a day " + amount);
            Console.WriteLine("amount of a day :" + days + "is: " + amount);
            stakeValue = stakeValue + amount;
            return result;
        }
        public int totalAmount_For20Days()
        {
            for (days = 1; days <= DAYS; days++)
            {
                gamblerGame();

            }
            Console.WriteLine("Total amount used during the game : " + stakeValue);
            Console.WriteLine("Totalamount won after a month " + winamount);
            Console.WriteLine("Totalamount loss after a month " + lossamount);
            int  totalAmount = STAKE * DAYS;
            Console.WriteLine("Totalamount is " + totalAmount);
            if (totalAmount > stakeValue)
            {
                int amountLoss = totalAmount - stakeValue;
                Console.WriteLine("amount loss is :" + amountLoss);
            }
            else if(totalAmount == stakeValue)
            {
                Console.WriteLine("No amount is loss or win");
            }
            else
            {
                int amountWon = stakeValue - totalAmount;
                Console.WriteLine("amount won is :" + amountWon);
            }
            Console.WriteLine("no.of won days is " + won);
            Console.WriteLine("no.of loss days is :" + loss);
            return result;
        }
    }
}
