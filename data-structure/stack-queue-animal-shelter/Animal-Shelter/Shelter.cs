using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter
{
    public class Shelter
    {

        public Node rear;
        public Node front;

        public Shelter()
        {
            rear = null;
            front = null;
        }


        //Enqueue Dog
        public void EnqueueDog(Dog dog)
        {
            Node newNode = new Node(dog);

            if (front == null)
            {
                rear = newNode;
                front = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            
        }

        //Enqueue Cat
        public void EnqueueCat(Cat cat)
        {
            Node newNode = new Node(cat);

            if (front == null)
            {
                rear = newNode;
                front = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        //Dequeue Dog
        public Dog DequeueDog()
        {
            Dog dog = null;

            if (front!= null)
            {
                if (front.next != null)
                {
                    dog = front.dog;
                    front = front.next;
                }
                else
                {
                    dog = front.dog;
                    front = null;
                    rear = null;
                }
            }

            return dog;
        }

        //Dequeue Cat
        public Cat DequeueCat()
        {
            Cat cat = null;

            if (front != null)
            {
                if (front.next != null)
                {
                    cat = front.cat;
                    front = front.next;
                }
                else
                {
                    cat = front.cat;
                    front = null;
                    rear = null;
                }
            }


            return cat;
        }

        //General function to decide which function to call
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Shelter is empty!");
            }
            else
            {
                if (front.Type == "Cat")
                {
                    DequeueCat();
                }
                else if (front.Type == "Dog")
                {
                    DequeueDog();
                }
            }

            
        }

        //public void Print()
        //{
        //    Node temp = rear;

        //    while (rear != null)
        //    {
        //        Console.WriteLine($"{temp.Type} ->");
        //        temp = temp.next;
        //    }
        //}


    }
}
