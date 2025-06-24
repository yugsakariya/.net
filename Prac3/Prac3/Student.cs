using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    internal class Student
    {
        long Enrollment_No;
        int Semester;
        string Student_name;
        double CPI,SPI;
        public Student(long Enrollment_No,int Semester,string Student_name,double CPI,double SPI)
        {
            this.Enrollment_No = Enrollment_No;
            this.Semester = Semester;
            this.Student_name = Student_name;
            this.CPI = CPI;
            this.SPI = SPI;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollment Number: {0}", Enrollment_No);
            Console.WriteLine("Student Name {0}", Student_name);
            Console.WriteLine("Semester: {0}", Semester);
            Console.WriteLine("CPI: {0}", CPI);
            Console.WriteLine("SPI: {0}", SPI);
        }
    }
}
