using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter
{
    public class Dog : Animal
    {
        public override string Type { get { return "dog"; } }

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
