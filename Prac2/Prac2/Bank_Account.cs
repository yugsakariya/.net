using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    internal class Bank_Account
    {
        int accouunt_no;
        string email,user_name,account_type;
        double account_balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Number:");
            accouunt_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter User Name:");
            user_name = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            account_type = Console.ReadLine();
            Console.WriteLine("Enter Account Balance:");
            account_balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + accouunt_no);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("User Name: " + user_name);
            Console.WriteLine("Account Type: " + account_type);
            Console.WriteLine("Account Balance: " + account_balance);
        }
    }
}
