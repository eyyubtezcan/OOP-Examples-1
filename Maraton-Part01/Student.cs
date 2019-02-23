using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton_Part01
{
    class Student
    {
        private string _FirstName;
        private string _LastName;
        private DateTime _DateOfBirth;
        private string _ClassRoom;
        private int _GradeAverage;
        private bool _IsGraduated;
        private int _ExamCount=0;
        private int _ExamSum = 0;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public string ClassRoom
        {
            get { return _ClassRoom; }
            set { _ClassRoom = value; }
        }
        public int GradeAverage
        {
            get { return _GradeAverage = _ExamSum / _ExamCount; }
           
        }
        public bool IsGraduated
        {
            get { return _IsGraduated; }
            set { _IsGraduated = value; }
        }

        public void AddExamGrade(int ExamResult)
        {
            
                if (_ExamCount < 10)
                {
                    _ExamCount++;
                    _ExamSum = _ExamSum+ ExamResult;
                
                }
                else
                {
                    if (GradeAverage > 70)
                    {
                        IsGraduated = true;
                    }
                    else
                    {
                        IsGraduated = false;
                        _ExamCount++;
                    _ExamSum = _ExamSum + ExamResult;

                    }
                }
            
           
        }
    }
}
