using System;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("About which language do you want to know information? 1 - English, 2 - Spanish, 3 - Ukrainian ");
            string line = Console.ReadLine();
            byte languageValue;

            if (byte.TryParse(line, out languageValue))
            {
                byte x = byte.Parse(line);
                if (x <= 3 && x > 0)
                {
                    Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
                    Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
                    Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");

                }
             //    else
            //        Console.WriteLine("Please follow the instructions and try again");

            }
            //else

            //{

            //    Console.WriteLine("Please follow the instructions and try again");

            //}

        }

        public enum Language : byte
        {
            English = 1,
            Spanish = 2,
            Ukrainian = 3,



        }
    }
}
