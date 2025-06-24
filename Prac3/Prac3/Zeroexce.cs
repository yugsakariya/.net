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
            int a, b;
            try {                 
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Division is {0}", c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: Division by zero is not allowed.{0}",e.Message);
            }
        }
    }
}
