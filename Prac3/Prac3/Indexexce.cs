using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    internal class Indexexce
    {
        public Indexexce()
        {
            int[] arr = new int[5];
            try
            {
                Console.WriteLine("Enter 5 numbers");
                for (int i = 0; i < 5; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter index to access");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Value at index {0} is {1}", index, arr[index]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: Index out of range. {0}", e.Message);
            }
        }
    }
}
