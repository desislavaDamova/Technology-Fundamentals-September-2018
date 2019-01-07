using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());

            int length = 0;
            int sum = 0;
            int startIndex = -1;
            int row = 0;
            int currentRow = 1;
            int[] DNA = new int[DNALength];

            string inputLine = Console.ReadLine();

            while (inputLine!="Clone them!")
            {
                int[] currentDNA = inputLine
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentSum = currentDNA.Sum();

                if (currentRow==1)
                {
                    DNA = currentDNA;
                    row = currentRow;
                    sum = currentSum;
                }

                int currentStartIndex = -1;
                int currentLength = 0;
                bool isFound = false;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i]==1)
                    {
                        if (isFound==false)
                        {
                            currentStartIndex = i;
                        }

                        currentLength++;

                        if (currentLength>length)
                        {
                            length = currentLength;
                            startIndex = currentStartIndex;
                            row = currentRow;
                            sum = currentSum;

                            DNA = currentDNA;
                        }
                        else if (currentLength==length)
                        {
                            if (currentStartIndex<startIndex)
                            {
                                length = currentLength;
                                startIndex = currentStartIndex;
                                row = currentRow;
                                sum = currentSum;

                                DNA = currentDNA;
                            }
                            else if (currentSum>sum)
                            {
                                length = currentLength;
                                startIndex = currentStartIndex;
                                row = currentRow;
                                sum = currentSum;

                                DNA = currentDNA;
                            }
                        }
                    }
                    else
                    {
                        currentStartIndex = -1;
                        currentLength = 0;
                        isFound = false;
                    }
                }
                currentRow++;
                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {row} with sum: {DNA.Sum()}.");
            Console.WriteLine(string.Join(" ",DNA));
        }
    }
}
