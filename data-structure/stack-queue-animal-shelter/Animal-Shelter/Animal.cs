﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter
{
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public virtual string Type { get; set; }

    }
}
