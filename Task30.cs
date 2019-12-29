using System;
using System.Collections.Generic;
using System.Linq;
namespace ProjectEuler
{
    internal class Task30
    {
        internal static void Execute()
        {
            int max = 355000;
            int min = 2;
            List<int> listOfNumbers = new List<int>();
            for (int i = min; i <= max; i++)
            {
                string iString = i.ToString();
                long sumOfPower = 0;
                foreach (var el in iString)
                {
                    double elDouble = Double.Parse(el.ToString());
                    sumOfPower += (long)Math.Pow(elDouble, 5);
                }
                if (sumOfPower == i)
                {
                    listOfNumbers.Add(i);
                }
            }
            Console.WriteLine(listOfNumbers.Sum());
        }
    }
}