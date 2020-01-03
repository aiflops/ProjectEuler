using System;

namespace ProjectEuler
{
    class Task8
    {
        public static string readText(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            string text= "";
            foreach (string line in lines)
            {
                text += line.Trim();
            }
            return text;
        }
        public static long solution(string text, int n)
        {
            long solution = 0;
            for (int i = 0; i < text.Length-n; i++)
            {
                int prod = 1;
                for (int j = 0; j <= n; j++)
                {
                    string sign = text[i + j].ToString();
                    int el = Convert.ToInt32(sign);
                    prod *= el;
                }
                solution = (prod>solution)? prod: solution;
            }
            return solution;
        } 
        public static void Execute()
        {
            string file = @"C:\Users\kkalfas\source\repos\ProjectEuler\Dane\Task8.txt";
            var text = Task8.readText(file);
            
            Console.WriteLine(Task8.solution(text,13));
            Console.ReadKey();

        }
    }
}