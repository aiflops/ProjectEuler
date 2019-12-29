using System;

namespace ProjectEuler
{
    internal class Task34
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
            int max = Task34.countFactor(9) * 7;
            int solution = 0;
            for (int i = 10; i < max; ++i)
            {
                string stringNumber = i.ToString();
                int sum = 0;
                foreach (var item in stringNumber)
                    sum += Task34.countFactor(int.Parse(item.ToString()));
                if (sum == i)
                    solution += sum;
            }
            Console.WriteLine(solution);
        }
    }
}