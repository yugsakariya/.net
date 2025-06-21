using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal class casechange
    {
        public casechange()
        {
            string str = Console.ReadLine();
            char a = Convert.ToChar(Console.ReadLine());
            string b = string.Empty;
            string newstr =string.Empty;
            foreach (char item in str)
            {
                if (item == a)
                {
                    Console.WriteLine("Character found in the string");
                    if (char.IsLower(item))
                    {
                        newstr+=item.ToString().ToUpper();
                        continue;
                    }
                    else
                    {
                        newstr += item.ToString().ToLower();
                        continue;
                    }
                }
                newstr += item;
            }
            Console.WriteLine(newstr);
        }
    }
}
