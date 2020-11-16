using System;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int isCount = 0;
            int quickCount = 0;
            int faultCount = 0;
            using (StreamReader textReader = new StreamReader("../../../text.txt"))
            {
                using (StreamReader wordReader = new StreamReader("../../../words.txt"))
                {
                    string[] currentWords = wordReader.ReadLine().Split().ToArray();
                    string currentText = textReader.ReadLine();
                    currentWords.ToString().ToLower().ToArray();
                    while (currentText != null)
                    {
                        currentText = currentText.ToLower();
                        if (currentText.Contains(currentWords[0]) || currentText.Contains(currentWords[1]) || currentText.Contains(currentWords[2]))
                        {
                            if (currentText.Contains(currentWords[0]))
                            {
                                quickCount++;
                            }
                            if (currentText.Contains(currentWords[1]))
                            {
                                isCount++;
                            }
                            if (currentText.Contains(currentWords[2]))
                            {
                                faultCount++;
                            }
                        }
                        currentText = textReader.ReadLine();
                    }
                }
            }
            using(StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                writer.WriteLine($"is - {isCount}");
                writer.WriteLine($"quick - {quickCount}");
                writer.WriteLine($"fault - {faultCount}");
            }
        }
    }
}
