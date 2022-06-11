using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace repeated_word
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static string MostRepeated(string s)
        {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            s = s.ToLower(); // Make all characters lower case

            // Remove non alphabetic characters
            s = s.Replace(",", "");
            s = s.Replace(".", "");
            s = s.Replace("!", "");
            s = s.Replace("?", "");
            s = s.Replace("/", "");
            s = s.Replace("&", "");

            string[] arr = s.Split(' ');

            foreach (string word in arr)
            {
                if (dictionary.ContainsKey(word)) // if it's in the dictionary
                {
                    dictionary[word] = dictionary[word] + 1; // Increment the count
                }
                else
                {
                    dictionary[word] = 1; // put it in the dictionary with a count 1
                }
            }

            KeyValuePair<string, int> mostRepeated = dictionary.First();

            foreach (KeyValuePair<string, int> x in dictionary)
            {
                if (x.Value > mostRepeated.Value)
                {
                    mostRepeated = x;
                }
            }

            return mostRepeated.Key;
        }
    }
}
