using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    class Faculty
    {
        int id;
        string name;
        int age;
        double weight;
        double height;
        public void GetFacDetails()
        {
            Console.WriteLine("Enter Faculty ID:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Faculty Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Faculty Age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Faculty Weight:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Faculty Height:");
            height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayFacDetails()
        {
            Console.WriteLine("Faculty ID: " + id);
            Console.WriteLine("Faculty Name: " + name);
            Console.WriteLine("Faculty Age: " + age);
            Console.WriteLine("Faculty Weight: " + weight);
            Console.WriteLine("Faculty Height: " + height);
        }
    }
}
