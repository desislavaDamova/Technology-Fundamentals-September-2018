using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            string result = $"{firstSymbol}{secondSymbol}{thirdSymbol}";

            Console.WriteLine(result);
        }
    }
}
