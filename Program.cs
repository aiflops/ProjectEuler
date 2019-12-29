using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numer of task : ");
            string numberOfTask = Console.ReadLine();

            switch (numberOfTask)
            {
                case "5":
                    Task5.Execute();
                    break;
                case "11":
                    Task11.Execute();
                    break;
                case "21":
                    Task21.Execute();
                    break;
                case "22":
                    Task22.Execute();
                    break;
                case "24":
                    Task24.Execute();
                    break;
                case "26":
                    Task26.Execute();
                    break;
                case "30":
                    Task30.Execute();
                    break;
                case "31":
                    Task31.Execute();
                    break;
                case "34":
                    Task34.Execute();
                    break;
                case "35":
                    Task35.Execute();
                    break;
                case "36":
                    Task36.Execute();
                    break;
            }
        }
    }
}
