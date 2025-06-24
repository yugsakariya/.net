using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                    Console.WriteLine("Enter lenght and breath of rectangle");
                    Rectangle rec = new Rectangle(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    ChildIN child = new ChildIN();
                    child.pareant();
                    child.child();
                    break;
                case 3:
                    Zeroexce zeroexce = new Zeroexce();
                    break;
                case 4:
                    Indexexce index = new Indexexce();
                    break;
                case 5:
                    Console.WriteLine("Enter Enrollment Number");
                    long Enrollmen_tNo = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Semester");
                    int Semester = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Student Name");
                    string Student_name = Console.ReadLine();
                    Console.WriteLine("Enter CPI");
                    double CPI = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter SPI");
                    double SPI = Convert.ToDouble(Console.ReadLine());
                    Student student = new Student(Enrollmen_tNo, Semester, Student_name, CPI, SPI);
                    student.DisplayStudentDetails();
                    break;
                case 6:
                    Console.WriteLine("Enter basic salary");
                    int basic = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter TA");
                    int TA = Convert.ToInt32(Console.ReadLine());
                    Salary salary = new Salary(basic, TA);
                    salary.calculate();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    public class Rectangle
    {
        public Rectangle(int l,int b)
        {
            
            Console.WriteLine("Area of Rectanlge is {0}",l*b);
        }
    }
}
