using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    internal class Task5
    {
        internal static void Execute()
        {
            List<long> arrayList = new List<long>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            long i = 100;
            while (true)
            {
                bool found = true;
                foreach (long item in arrayList)
                {
                    if (i % item == 0)
                        found = true;
                    else
                    {
                        found = false;
                        break;
                    }
                }
                if (found == true)
                    break;
                else
                    i++;
            }
            Console.WriteLine(i);

        }
    }
}