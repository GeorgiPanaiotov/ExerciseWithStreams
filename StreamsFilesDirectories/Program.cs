using System;
using System.IO;

namespace StreamsFilesDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                int count = 0;
                string line = reader.ReadLine();
                while(line != null)
                {
                    if(count % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    count++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
