using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitalizeWordsCodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = {
                                "Hello world",
                                "javaScript language",
                                "a letter",
                                "1st thing"
                             };
            foreach (string line in lines)
            {
                string[] sentence = line.Split(' ');
                int i, sentLen = sentence.Length;
                for (i = 0; i < sentLen; i++)
                {
                    Console.Write(TitleCase(sentence[i]));
                    if (i < sentLen - 1)
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        static string TitleCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] upCase = s.ToCharArray();
            upCase[0] = char.ToUpper(upCase[0]);
            return new string(upCase);
        }
    }
}
