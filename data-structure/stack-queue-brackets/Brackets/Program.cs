using System;
using System.Collections;
using System.Collections.Generic;

namespace Brackets
{
    public class Program
    {
        //static Stack<char> left = new Stack<char>();

        //static Stack<char> leftReverse = new Stack<char>();


        //static Stack<char> right = new Stack<char>();


        static List<char> list = new List<char>();

        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter your string: ");

            string input = Console.ReadLine();

            Console.WriteLine(FirstStep(RemoveButBrackets(input))); 

            

        }

        /// <summary>
        /// Remove Brackets that's unncessary to check
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool FirstStep(string s)
        {
            int n = -1;
            while (s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }

            if (n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string RemoveButBrackets(string x)
        {
            string result = "";

            char[] v = x.ToCharArray();

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == '(' ||
                    v[i] == ')' ||
                    v[i] == '[' ||
                    v[i] == ']' ||
                    v[i] == '{' ||
                    v[i] == '}')
                {
                    list.Add(v[i]);
                    result += v[i];
                }
            }
            return result;
        }

        //public static void SecondStep(char[] x)
        //{
        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        if (x[i] == '{' ||
        //            x[i] == '(' ||
        //            x[i] == '[')
        //        {
        //            left.Push(x[i]);
        //        }

        //        else if (x[i] == '}' ||
        //                 x[i] == ')' ||
        //                 x[i] == ']')
        //        {
        //            right.Push(x[i]);
        //        }
        //    }

        //    while (left.Count > 0)
        //    {
        //        leftReverse.Push(left.Pop());
        //    }
        //}



        //public static bool Validate(string x)
        //{
        //    string updatedX = FirstStep(x);

        //    if (FirstStep(x).Length == 0)
        //    {
        //        return true;
        //    }

        //    SecondStep(updatedX.ToCharArray());


        //    if (leftReverse.Count == right.Count)
        //    {
        //        while (leftReverse.Count > 0)
        //        {
        //            if (leftReverse.Peek() == right.Peek())
        //            {
        //                leftReverse.Pop();
        //                right.Pop();
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }

        //    else
        //    {
        //        return false;
        //    }
        //}
        
    }
}
