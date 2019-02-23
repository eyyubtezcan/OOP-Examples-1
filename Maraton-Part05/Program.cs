using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton_Part05
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom clsrm = new Classroom("5A", 20, 5);
            
            Class cls = new Class();

            cls.Classrooms = clsrm;

            cls.AddStudent("dfdfdf");
            cls.AddStudent("aaaaa");
            cls.AddStudent("vvvv");
            cls.AddStudent("dfdfdf");
            cls.AddStudent("aaaaa");
          
         
            //cls.AddStudent("aaaaa");
            //cls.AddStudent("vvvv");
            //cls.AddStudent("dfdfdf");
            //cls.AddStudent("aaaaa");
            cls.AddStudent("vvvv");
            cls.AddStudent("aaaaa");
            cls.AddStudent("vvvv");
            //cls.AddStudent("aaaaa");
            //cls.AddStudent("vvvv");
            //cls.AddStudent("aaaaa");
            //cls.AddStudent("vvvv");
            //cls.AddStudent("kkkkkdf");
            cls.AddStudent("lllll");
            cls.AddStudent("dppp");
            cls.AddStudent("aaaaa");
            cls.AddStudent("vvvv");
            cls.AddStudent("aaaaa");
            cls.AddStudent("vvvv");


            for (int i = 0; i < cls.Students.Length; i++)
            {
                Console.WriteLine(i+" "+cls.Students[i]);
            }


            Console.WriteLine("--------------------------");
            cls.RemoveStudent("vvvv");
            for (int i = 0; i < cls.Students.Length; i++)
            {
                Console.WriteLine(i + " " + cls.Students[i]);
            }
            //TEST
            Console.WriteLine(((((cls.Students.Length * 100) / cls.Classrooms.capacity))));
            Console.WriteLine("Class is ready ? "+cls.ReadyToStart);
           
            Console.ReadLine();
        }
    }
}
