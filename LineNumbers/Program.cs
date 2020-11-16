using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                string line = reader.ReadLine();
                int count = 1;
                while(line != null)
                {
                    Console.WriteLine($"{count}. {line}");
                    line = reader.ReadLine();
                    count++;
                }
            }
        }
    }
}
