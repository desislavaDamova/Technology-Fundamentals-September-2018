using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            decimal expenses = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if (i % 6 == 0)
                {
                    keyboardCount++;
                }
                if (i % 12 == 0)
                {
                    displayCount++;
                }
            }
            expenses = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
