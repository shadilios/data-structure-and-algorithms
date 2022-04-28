using System;

namespace Animal_Shelter
{
    public class Program
    {
        static void Main(string[] args)
        {

            Shelter shelter = new Shelter();

            Dog dog1 = new Dog("Rex", 3);
            Dog dog2 = new Dog("Poppy", 2);
            Dog dog3 = new Dog("Dobber", 7);

            Cat cat1 = new Cat("Lola", 6);
            Cat cat2 = new Cat("Lilly", 1);
            Cat cat3 = new Cat("Kata", 2);

            shelter.Enqueue(dog1);
            shelter.Enqueue(cat2);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog3);
            shelter.Enqueue(cat1);
            shelter.Enqueue(cat3);

            Animal a = shelter.Dequeue("cat");

            Console.WriteLine(a.Name);
        }
    }
}
