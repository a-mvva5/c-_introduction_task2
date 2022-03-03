using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ay = Convert.ToString(Console.ReadLine());
            switch (ay)
            {
                case "yanvar":
                    Console.WriteLine("31");
                    break;
                case "fevral":
                    Console.WriteLine("28");
                    break;
                case "mart":
                    Console.WriteLine("31");
                    break;
                case "apel":
                    Console.WriteLine("30");
                    break;
                case "may":
                    Console.WriteLine("31");
                    break;
                case "iyun":
                    Console.WriteLine("30");
                    break;
                case "iyul":
                    Console.WriteLine("30");
                    break;
                case "avqust":
                    Console.WriteLine("31");
                    break;
                case "sentyabr":
                    Console.WriteLine("30");
                    break;
                case "oktyabr":
                    Console.WriteLine("31");
                    break;
                case "noyabr":
                    Console.WriteLine("30");
                    break;
                case "dekabr":
                    Console.WriteLine("31");
                    break;



            }
        }
    }
}
