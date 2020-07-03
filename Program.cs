using System;

namespace App24
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int prod = 1;
            int count = 0;
            do
            {
                input = Console.ReadLine();
                if (input != "x")
                {
                    count++;
                    int value = int.Parse(input);
                    for (int i = 0; i < count; i++)
                    {
                        prod *= value;
                        count--;
                    }
                }
                else
                {
                    break;
                }
            } while (!(input == "x"));
            Console.WriteLine(prod);
        }
    }
}
