using System.Numerics;
using System;
namespace ProjectEuler
{
    class Task20
    {
        public static int CharToInt3(char input)
        {
            double temp = Char.GetNumericValue(input);
            int result = Convert.ToInt32(temp);
            return result;
        }

        public static void Execute() {
            int n = 100;
            BigInteger result = 1;
            for (int i = 1; i <= n ; i++)
            {
                result = result * i;
            }
            string resultString = result.ToString();
            int length = resultString.Length;
            int index = 0;
            int sum=0;
            while (index < length)
            {
                int con = Task20.CharToInt3(resultString[index]);
                sum = sum + con;
                index++;
            }
            System.Console.WriteLine(sum);
            System.Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}