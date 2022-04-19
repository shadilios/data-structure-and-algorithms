using System;

namespace Animal_Shelter
{
    public class Program
    {
        static void Main(string[] args)
        {

            Dog dog1 = new Dog("Poppy");
            Dog dog2 = new Dog("Kayn");
            Dog dog3 = new Dog("Rex");

            Cat cat1 = new Cat("Yumi");
            Cat cat2 = new Cat("Neko");
            Cat cat3 = new Cat("Mix");

            Shelter shelter = new Shelter();

            shelter.EnqueueCat(cat1);
            shelter.EnqueueCat(cat2);
            shelter.EnqueueCat(cat3);

            shelter.Dequeue();


        }
    }
}
