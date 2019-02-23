using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton_Part05
{
    class Class
    {
        private string _Lesson;
        private string _Code;        
        private string[] _Students = new string[0];
        private bool _ReadyToStart=false;
        public int capacity { get; set; }
        public virtual Classroom Classrooms { get; set; }
        
        public string Lesson
        {
            get
            {
                return _Lesson;
            }

        }
        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
            }
        }
       
        public string[] Students
        {
            get
            {
               
                return _Students;
            }
            set
            {

            }

        }

        public bool ReadyToStart
        {
            get
            {
                int a = Classrooms.capacity;
                bool result;
              
                if ((((_Students.Length * 100) / Classrooms.capacity) > 70) && (Classrooms.code != ""))
                {
                    result = true;
                }
                else { result = false; }

                return result;
            }
           
        }

        public void AddStudent(string studentname)
        {
           
            if (Classrooms.capacity-_Students.Length>0)
            {
            Array.Resize(ref _Students, _Students.Length + 1);
            _Students[_Students.Length - 1] = studentname;
            }
            else { throw new ApplicationException("You cant add new student. Because capacity full"); }   
        }
        public void RemoveStudent(string studentname)
        {
            int a = Array.FindIndex(_Students, element => element.Equals(studentname));

            int i = a;
            while (i < _Students.Length - 1)
            {
                _Students[i] = _Students[i + 1];
                i++;
            }
            Array.Resize(ref _Students, _Students.Length - 1);
        }

    }
}
