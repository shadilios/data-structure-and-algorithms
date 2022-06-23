using System;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "hi my name is shadi shadi hi my my";

            //RepeatedWord(x);
            Console.WriteLine(RepeatedWord(x)); 
        }

        public static string RepeatedWord(string text)
        {
            string mostRepeatedWord = "";
            int mostRepetition = 0;

            text.ToLower();

            string[] seperated = text.Split(' ');

            Hashtable table = new Hashtable();

            


            for (int i = 0; i < seperated.Length; i++)
            {
                if (!table.Contains(seperated[i]))
                {
                    table.Add(seperated[i], 1);
                }
                else if (table.Contains(seperated[i]))
                {
                    int currentRepetition = (int)table[seperated[i]];
                    table.Remove(seperated[i]);
                    table.Add(seperated[i], ++currentRepetition);

                    if ((currentRepetition + 1) > mostRepetition)
                    {
                        mostRepetition = currentRepetition + 1;
                        mostRepeatedWord = seperated[i];
                    }
                }
            }

            return mostRepeatedWord;

        }
    }
}
