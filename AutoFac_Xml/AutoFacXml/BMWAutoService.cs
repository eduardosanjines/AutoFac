﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacXml
{
    public class BMWAutoService : IAutoService
    {
        public void GetService()
        {
            Console.WriteLine("BMW");
        }
    }
}
