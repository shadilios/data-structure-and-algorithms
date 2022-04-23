using System;
using System.Collections;
using System.Collections.Generic;




namespace duckduckgoose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DuckDuckGoose("A", "B", "C", "D", "E", "F", 3);
        }


        static void DuckDuckGoose(string a, string b, string c, string d, string e, string f, int k)
        {
            List<string> list = new List<string>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            list.Add(e);
            list.Add(f);

            while (list.Count != 1)
            {
                for (int i = 1; i <= k; i++)
                {
                    //I need to make a count here, to loop over the list from beginning to end without going to an element outside the list

                    list.Remove(list[i]);
                    list.ToString();
                }
            }

        }

    }
}
