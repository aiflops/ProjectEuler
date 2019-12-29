using System;

namespace ProjectEuler
{
    internal class Task36
    {
        public static bool IsPalindromeString(int number, int b)
        {
            string stringNumber = Convert.ToString(number, b);
            var arr = stringNumber.ToCharArray();
            Array.Reverse(arr);
            return stringNumber.Equals(new string(arr));
        }
        internal static void Execute()
        {
            int max = 1000000;
            int solution = 0;
            for (int i = 1; i < max; i += 2)
                if (Task36.IsPalindromeString(i, 10)
                    && Task36.IsPalindromeString(i, 2)
                  )
                    solution += i;
            Console.WriteLine(solution);
        }
    }
}