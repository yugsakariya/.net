using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    public class SingleIN
    {
        public SingleIN()
        {
            Console.WriteLine("This is parent constructor");
        }
        
    }
    public class ChildIN : SingleIN
    {
        public ChildIN()
        {
            Console.WriteLine("This is child constructor");
        }
        
    }
}