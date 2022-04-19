using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter
{
    public class Node
    {
        public Dog dog;

        public Cat cat;

        public Node next;

        public string Type { get; set; }

        public Node(Dog dog)
        {
            this.dog = dog;
            this.Type = "Dog";
            next = null;
        }

        public Node (Cat cat)
        {
            this.cat = cat;
            this.Type = "Cat";
            next = null;
        }
    }
}
