using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    public class Zeroexce
    {
        public Zeroexce()
        {
            int a=10, b=0;
            try {                 
                Console.WriteLine("Divide by zero Exception will ouccer");
                int c = a / b;
                Console.WriteLine("Division is {0}", c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    }
