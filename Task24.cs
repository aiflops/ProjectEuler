using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    internal class Task24
    {
        public static int countFactor(int n)
        {
            int p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
            }
            return p;
        }
        internal static void Execute()
        {
            List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int element = 1000000 -1;
            int N = 10;
            string numer = "";
            for (int i = 9; i >= 0; i--)
            {
                int amountOfFactor = element / Task24.countFactor(i);
                element %=  Task24.countFactor(i);
                numer += digits[amountOfFactor];
                digits.RemoveAt(amountOfFactor);

            }

            Console.WriteLine(numer);
        }
    }
}

//int countedFactory = Task24.countFactor(factory);
//sum += countedFactory;
//if (sum == element)
//    continue;
//else if(sum > element)
//{
//    sum -= countedFactory;
//    factory--;
//    numberString += elementOfNumber.ToString();
//    elementOfNumber = 0;
//}
//else if(sum < element)
//{
//    elementOfNumber++;
//}