﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Polymorphism_Example.Class
{
    
    public class Warwick : Charackter
    {
        Random random = new Random();
        public override int GetSpeed()
        {
            return random.Next(20,35);
        }
    }
}
