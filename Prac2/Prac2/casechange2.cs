using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal class casechange2
    {
        public casechange2()
        {
            string str = Console.ReadLine();
            //char a = Convert.ToChar(Console.ReadLine());
            //string b = string.Empty;
            string newstr = string.Empty;
            foreach (char item in str)
            { 
                    //Console.WriteLine("Character found in the string");
                    if (char.IsLower(item))
                    {
                        newstr += item.ToString().ToUpper();
                    }
                    else
                    {
                        newstr += item.ToString().ToLower();
                    }
            }
            Console.WriteLine(newstr);
        }
    }
}
