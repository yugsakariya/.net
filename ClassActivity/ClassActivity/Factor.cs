using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity
{
    class Factor
    {
        public Factor()
        {
            int num, i;
            Console.WriteLine("Enter a number to find its factors:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors of " + num + " are:");
            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
