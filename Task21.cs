using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class ANumber {
        public int value { get; set; }
        public long sumOfDivisors { get; set; }
        public List<int> divisors { get; set; }
        public ANumber(int value)
        {
            this.value = value;
            this.setDivisors();
            this.setSumOFDivisors();
        }

        public void setSumOFDivisors()
        {
            if (this.divisors.Count > 0)
                this.sumOfDivisors = this.divisors.Sum();
        }
        public int getMaxDivisors()
        {
            this.setDivisors();
            return this.divisors.Max();
        }

        public void setDivisors()
        {
            List<int> lstDivisors = new List<int>();
            double max;

            max = Math.Sqrt(this.value);

            for (int i = 1; i <= max; i++)
            {
                if (this.value % i == 0)
                {
                    int quotient = this.value / i;

                    lstDivisors.Add(i);
                    if(quotient!=i && quotient!=this.value)
                        lstDivisors.Add(quotient);
                }
            }
            lstDivisors.Sort();
            this.divisors = lstDivisors;
        }
        public void setDivisorsFromList(List<int> otherDivisors, int biggestDivisor) {
            otherDivisors.Add(biggestDivisor);
        }
        public void show()
        {
            Console.WriteLine("value " +value+ " sum: "+ sumOfDivisors + " max div "+ this.getMaxDivisors());
            if(this.divisors != null)
                foreach (var item in this.divisors)
                {
                    Console.WriteLine(item);
                }
        }
        public static bool findInDivisors(int number, List<ANumber> cache)
        {
            return cache.Exists(x => x.value == number);
        }

    }
    internal class Task21
    {
        public static void Execute()
        {
            List<ANumber> cache = new List<ANumber>();
            long sumAmicable =  0;
            for (int i = 2; i <= 10000; i++)
            {
                var tmpANumber = new ANumber(i);
                var isInCache = ANumber.findInDivisors(tmpANumber.value, cache);
                if (isInCache == true)
                {
                    continue;
                }
                else
                {
                    var tmpMaybeAmicable = new ANumber((int)tmpANumber.sumOfDivisors);
                    cache.Add(tmpANumber);
                    cache.Add(tmpMaybeAmicable);
                    if(tmpMaybeAmicable.sumOfDivisors == tmpANumber.value
                    && tmpANumber.value != tmpMaybeAmicable.value )
                    {
                        sumAmicable += (tmpANumber.value + tmpMaybeAmicable.value);
                    }
                }
            }
            Console.WriteLine("Suma to "+ sumAmicable);
        }
    }
}