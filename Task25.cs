using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    internal class Task25
    {
        public static BigInteger countFibb(BigInteger limit)
        {
            BigInteger index = 2;
            BigInteger n_1 = 1;
            BigInteger n_2 = 1;
            BigInteger n = 0;
            while (n <= limit)
            {
                n = n_1 + n_2;
                n_2 = n_1;
                n_1 = n;
                index++;
            }
            return index;

        }
        public static void Execute()
        {
            var tmp = "1" + new String('0', 999);
            BigInteger limit = BigInteger.Parse(tmp);
            Console.WriteLine("index: " + Task25.countFibb(limit));
            Console.ReadKey();

        }

    }
}