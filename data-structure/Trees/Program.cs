using System;

namespace TREE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST x = new BST();
            Console.WriteLine("&");

            x.Add(1);
            Console.WriteLine(x.Root.data);
            Console.WriteLine("&");

            x.Add(5);
            Console.WriteLine("&");

            x.Add(10);
            Console.WriteLine("&");

            x.Add(15);
            Console.WriteLine("&");

            x.Add(20);
            Console.WriteLine("&");

            x.Add(25);

            Console.WriteLine("*");
            Console.WriteLine(x.Root.data);
            Console.WriteLine(x.Root.left.data);
            Console.WriteLine(x.Root.right.data);



        }
    }


}
