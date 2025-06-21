using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity
{
    class Parfect
    {
        public Parfect()
        {
            int num, sum=0;
            Console.WriteLine("Eneter a Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            //Console.WriteLine(sum +" "+ num);
            if (sum == num)
            {
                Console.WriteLine("Number is Perfect");
            }
            else
            {
                Console.WriteLine("Number is not Perfect");
            }
        }
    }
}
