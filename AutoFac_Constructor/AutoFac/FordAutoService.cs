using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Constructor
{
    public class FordAutoService : IAutoService
    {
        public void GetService()
        {
            Console.WriteLine("Ford");
        }
    }
}
