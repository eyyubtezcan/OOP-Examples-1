using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton_Part01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stdnt = new Student();
            stdnt.FirstName = "dsdsds";
            stdnt.LastName = "dfdfdf";
            stdnt.AddExamGrade(100);
            stdnt.AddExamGrade(100);
            stdnt.AddExamGrade(100);
            stdnt.AddExamGrade(100);
            stdnt.AddExamGrade(00);
            stdnt.AddExamGrade(00);
   
            stdnt.AddExamGrade(100);
            stdnt.AddExamGrade(100);
            Console.WriteLine(stdnt.FirstName);
            Console.WriteLine(stdnt.LastName);
            Console.WriteLine(stdnt.IsGraduated);
            Console.WriteLine(stdnt.GradeAverage);
            Console.ReadLine();
        }
    }
}
