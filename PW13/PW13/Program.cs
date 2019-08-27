using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticalWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var numbersAsArrayList = new ArrayList();
            var sizeOfList = 10;
            for (var i = 0; i < sizeOfList; i++)
            {
                numbersAsArrayList.Add(rand.Next(1, 100));
                Console.Write($"{numbersAsArrayList[i]} ");
            }
            Console.WriteLine();
            for (var i = 0; i < numbersAsArrayList.Count; i++)
            {
                if ((int)numbersAsArrayList[i] % 2 != 0)
                {
                    numbersAsArrayList.RemoveAt(i);
                    i--;
                }
            }
            for (var i = 0; i < numbersAsArrayList.Count; i++)
            {
                Console.Write($"{numbersAsArrayList[i]} ");
            }
            Console.ReadKey();
            Console.Clear();

            var listOfNumbers = new List<int>();
            var sumOfNumbers = 0;
            for (var i = 0; i < sizeOfList; i++)
            {
                listOfNumbers.Add(rand.Next(1, 100));
                Console.Write($"{listOfNumbers[i]} ");
            }
            Console.WriteLine();
            for (var i = 0; i < listOfNumbers.Count; i++)
            {
                sumOfNumbers += listOfNumbers[i];
            }
            var avarageOfNumbers = sumOfNumbers / listOfNumbers.Count;
            for (var i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] > avarageOfNumbers)
                {
                    Console.Write($"{listOfNumbers[i]} ");
                }
            }

            Console.ReadKey();
        }
    }
}
ы