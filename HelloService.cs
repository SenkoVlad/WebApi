﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class HelloService
    {
        public string SayHello(string name)
        {
            return $"Hellow {name}";
        }
    }
}
