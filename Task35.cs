using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class PemutationNumber
    {
        public int value;
        public char[] valueArray { get; set; }
        public List<int> listPermutation { get; set;}
        public PemutationNumber(int value){
            this.value = value;
            this.valueArray = value.ToString().ToCharArray();
            this.listPermutation = new List<int>();
        }
        private  void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }
        public  void GetPer()
        {
            int x = this.valueArray.Length - 1;
            GetPer(this.valueArray, 0, x);
        }
        private void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                string tmp = "";
                foreach (var item in list)
                {
                    tmp += item;
                }
                this.listPermutation.Add(int.Parse(tmp.ToString()));
                //Console.WriteLine(tmp);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }
        public int numberOfDigits(int n)
        {
            int cnt = 0;
            while (n > 0)
            {
                cnt++;
                n /= 10;
            }
            return cnt;
        }

        public void rotation()
        {
            int digits = numberOfDigits(this.value);
            int powTen = (int)Math.Pow(10, digits - 1);
            for (int i = 0; i < digits - 1; i++)
            {

                int firstDigit = this.value / powTen;
                int left
                    = ((this.value * 10) + firstDigit)
                    - (firstDigit * powTen * 10);
                this.listPermutation.Add(left);
                this.value = left;
            }
        }

    }
    public static class PrimeTool
    {
        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
    internal class Task35
    {
        public static bool isPossibleCircle(int number)
        {
            string numberString = number.ToString();
            if(    numberString.Contains('2')
                || numberString.Contains('4')
                || numberString.Contains('5')
                || numberString.Contains('6')
                || numberString.Contains('8')
                || numberString.Contains('0')
                )
                return false;
            else
                return true;
        }
        public static bool IsCircle(PemutationNumber number)
        {
            foreach (var item in number.listPermutation)
            {
                if (PrimeTool.IsPrime(item) == false)
                    return false;
            }
            return true;
        }
        internal static void Execute()
        {
            int max = 1000000;
            int solution = 4;
            for (int i=10; i<max; i++)
            {
                if (Task35.isPossibleCircle(i))
                {
                    var pemutationNumber = new PemutationNumber(i);
                    pemutationNumber.rotation();
                    if (Task35.IsCircle(pemutationNumber) == true)
                    {
                        Console.WriteLine(i);
                        solution++;
                    }
                }
            }
            Console.WriteLine(solution);

        }
    }
}