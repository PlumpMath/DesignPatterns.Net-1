﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopFactoryMethod
{
    public interface ILaptopFactory
    {
        Laptop CreateLaptop();
    }
}
