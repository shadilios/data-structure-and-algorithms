using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter
{
    public class Shelter
    {

        public Queue<Animal> Animals = new Queue<Animal>();
        public Queue<Animal> SecondQueue = new Queue<Animal>();



        public void Enqueue(Animal animal)
        {
            Animals.Enqueue(animal);
        }

        public Animal Dequeue(string type)
        {
            if (Animals.Count + SecondQueue.Count == 0)
            {
                throw new Exception("SHELTER HAS NO ANIMALS!!");
            }


            Animal anim = null;


            if (SecondQueue.Count == 0)
            {
                while (Animals.Peek().Type != type)
                {
                    SecondQueue.Enqueue(Animals.Dequeue());
                    
                    if (Animals.Peek().Type == type)
                    {
                        anim = Animals.Dequeue();
                        break;
                    }
                }
            }

            else if(SecondQueue.Count > 0)
            {
                while (SecondQueue.Peek().Type != type)
                {
                    Animals.Enqueue(SecondQueue.Dequeue());

                    if (SecondQueue.Peek().Type == type)
                    {
                        anim = SecondQueue.Dequeue();
                        break;
                    }
                }
            }

            



            return anim;
            
        }

    }
}
