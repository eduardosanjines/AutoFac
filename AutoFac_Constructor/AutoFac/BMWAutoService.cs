﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac
{
    public class BMWAutoService : AutoService
    {
        public void GetService()
        {
            Console.WriteLine("BMW");
        }
    }
}