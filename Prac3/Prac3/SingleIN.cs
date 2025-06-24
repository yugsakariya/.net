using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    public class SingleIN
    {
        public void pareant()
        {
            Console.WriteLine("This is Parent class");
        }
    }
    public class ChildIN : SingleIN
    {
        public void child()
        {
            Console.WriteLine("This is Child class");
        }
    }
}