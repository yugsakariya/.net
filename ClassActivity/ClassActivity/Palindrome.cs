using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity
{
    class Palindrome
    {
        public Palindrome()
        {
            int num;
            string str, rev = string.Empty;
            Console.WriteLine("Enter a Number");
            num = Convert.ToInt32(Console.ReadLine());
            str = num.ToString();
            Console.WriteLine("String is: " + str);
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            if (str == rev)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
