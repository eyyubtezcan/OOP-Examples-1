using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton_Part05
{
    class Classroom
    {
        private string _code;
        private int _capacity=5;
        private int _floor=1;
        public virtual Class Class { get; set; }


      

        public Classroom(string code)
        {
            _code = code;
        }
        public Classroom(string code, int capacity)
        {
            _code = code;
        }
        public Classroom(string code, int capacity, int floor)
        {
            _code = code;
            _capacity = capacity;
            _floor = floor;
        }


        public string code
        {
            get
            {
                return _code;
            }
            
        }
        public int capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (value < 5) { _capacity = 5; }
                else
                {
                    if (value > 25) { _capacity = 25; }
                    else { _capacity = value; }
                }

            }
        }
        public int floor
        {
            get
            {
                return _floor;
            }
            set
            {
                if (value < 1) { _floor = 1; }
                else
                {
                    if (value > 5) { _capacity = 5; }
                    else { _capacity = value; }
                }

            }
        }

    }
}
