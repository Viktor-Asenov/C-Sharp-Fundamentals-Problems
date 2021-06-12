using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int bestLenght = 1;
            int bestStartIndex = 0;            
            int bestDnaSum = 0;
            int sequenceCounter = 0;
            int bestSequenceIndex = 0;
            int[] bestDna = new int[n];

            while (command != "Clone them!")
            {
                int[] currentDna = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int lenght = 1;
                int bestCurrentDnaLenght = 1;
                int startIndex = 0;
                int currentDnaSum = 0;
                
                sequenceCounter++;

                for (int i = 0; i < currentDna.Length - 1; i++)
                {
                    if (currentDna[i] == currentDna[i+1])
                    {
                        lenght++;                        
                    }
                    else
                    {
                        lenght = 1;                        
                        startIndex = i;                        
                    }

                    if (lenght > bestCurrentDnaLenght)
                    {
                        bestCurrentDnaLenght = lenght;
                        startIndex = i;
                        bestDnaSum = currentDnaSum;
                    }                   
                
                    currentDnaSum += currentDna[i];
                }

                if (bestCurrentDnaLenght > bestLenght)
                {
                    bestLenght = bestCurrentDnaLenght;
                    bestStartIndex = startIndex;
                    bestDnaSum = currentDnaSum;
                    bestSequenceIndex = sequenceCounter;
                    bestDna = currentDna;
                }
                else if (bestCurrentDnaLenght == bestLenght)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLenght = bestCurrentDnaLenght;
                        bestStartIndex = startIndex;
                        bestDnaSum = currentDnaSum;
                        bestSequenceIndex = sequenceCounter;
                        bestDna = currentDna;
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentDnaSum > bestDnaSum)
                        {
                            bestLenght = bestCurrentDnaLenght;
                            bestStartIndex = startIndex;
                            bestDnaSum = currentDnaSum;
                            bestSequenceIndex = sequenceCounter;
                            bestDna = currentDna;
                        }
                    }
                }
                
                command = Console.ReadLine();
            }          
            
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(String.Join(' ', bestDna));
     
        }
    }
}
