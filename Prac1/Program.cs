using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Prac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Enter 1,2,3.1,3.2,4,5 or 6: ");
            a = Convert.ToDouble(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Yug");
                    Console.WriteLine("Rajkot");
                    Console.WriteLine("Rajkot");
                    Console.WriteLine("1234567890");
                    break;
                case 2:
                    double area, r, l, b;
                    Console.WriteLine("Enter radius of Circle: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    double pi = 3.14;
                    area = (pi * r * r);
                    Console.WriteLine("Area of Circle: " + area);
                    Console.WriteLine("Enter length and breadth of Rectangle: ");
                    l = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    area = l * b;
                    Console.WriteLine("Area of Rectangle: " + area);
                    Console.WriteLine("Enter Lenght of Square");
                    l = Convert.ToDouble(Console.ReadLine());
                    area = l * l;
                    Console.WriteLine("Area of Square: " + area);
                    break;
                case 3.1:
                    char choice;
                    Console.WriteLine("Enter two numbers: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter your choice: \n+ Addition.\n- Subtraction.\n* Multiplication.\n/ Division");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice == '+')
                    {
                        Console.WriteLine("Addition:" + (a + b));
                    }
                    else if (choice == '-')
                    {
                        Console.WriteLine("Subtraction:" + (a - b));
                    }
                    else if (choice == '*')
                    {
                        Console.WriteLine("Multiplication:" + (a * b));
                    }
                    else if (choice == '/')
                    {
                        if (b != 0)
                        {
                            Console.WriteLine("Division:" + (a / b));
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                    break;
                case 3.2:
                    Console.WriteLine("Enter two numbers: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter your choice: \n+ Addition.\n- Subtraction.\n* Multiplication.\n/ Division");
                    choice = Convert.ToChar(Console.ReadLine());
                    switch (choice)
                    {
                        case '+':
                            Console.WriteLine("Addition: " + (a + b));
                            break;
                        case '-':
                            Console.WriteLine("Subtraction: " + (a - b));
                            break;
                        case '*':
                            Console.WriteLine("Multiplication: " + (a * b));
                            break;
                        case '/':
                            if (b != 0)
                            {
                                Console.WriteLine("Division: " + (a / b));
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by zero.");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;
                case 4:
                    double fehrenheit, celsius;
                    Console.WriteLine("Enter temperature in Celsius: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fehrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit: " + fehrenheit);
                    Console.WriteLine("Enter temperature in Fahrenheit: ");
                    fehrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fehrenheit - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius: " + celsius);
                    break;
                case 5:
                    double i, p, n;
                    Console.WriteLine("Enter Principal Amount: ");
                    p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Rate of Interest: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Time in Years: ");
                    n = Convert.ToDouble(Console.ReadLine());
                    i = (p * r * n) / 100;
                    Console.WriteLine("Simple Interest: " + i);
                    break;
                case 6:
                    double c;
                    Console.WriteLine("Enter three numbers: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());
                    double largest = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
                    Console.WriteLine("Largest number is: " + largest);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter only 1,2,3.1,3.2,4,5,6");
                    break;
            }
        }
    }
}