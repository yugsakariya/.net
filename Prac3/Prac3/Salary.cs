using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    internal class Salary
    {
        int basic;
        int hra;
        int da;
        int ta;
        public Salary(int basic,int ta) 
        {
            this.da = 25000;
            this.hra = 15000;
            this.basic = basic;
            this.ta = ta;
        }
        public void calculate()
        {
            Console.WriteLine("Total Salary is{0}",da+ta+hra+basic);
        }

    }
}
