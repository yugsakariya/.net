using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity
{
    class Prime
    {
        public Prime()
        {
            int num;
            bool con_var = false;
            Console.WriteLine("Enter a Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    con_var = true;
                }
            }
            if (con_var)
            {
                //Console.WriteLine(con_var);
                Console.WriteLine("Number is not Prime");
            }
            else
            {
                //Console.WriteLine(con_var);
                Console.WriteLine("Number is Prime");
            }
        }
    }
}
