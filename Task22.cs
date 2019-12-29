using System;
using System.IO;
using System.Linq;

namespace ProjectEuler
{
    internal class Task22
    {
        public static string[] ReadInput(string filename)
        {
            StreamReader r = new StreamReader(filename);
            string line = r.ReadToEnd();
            r.Close();

            string[] names = line.Split(',');

            return names;
        }

        internal static void Execute()
        {
            string filename = @"C:\Users\kaspero\source\repos\ProjectEuler\ProjectEuler\data22.txt";
            var listNames = Task22.ReadInput(filename).ToList<string>();
            long total = 0;
            listNames.Sort();
            
            for (int i = 0; i < listNames.Count; i++)
            {
                var name = listNames[i];
                int sumOfAllLetters = 0;
                foreach (var letter in name)
                {
                    sumOfAllLetters += (Convert.ToInt16(letter)- 64);
                }
                total += sumOfAllLetters * (i+1);
            }
            Console.WriteLine(total);
        }
    }
}