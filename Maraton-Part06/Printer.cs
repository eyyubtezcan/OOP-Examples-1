using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton_Part06
{
    class Printer
    {
        private string _Make;
        private string _Model;
        private int _Paper;
        private bool _PrinterStatus;

        public bool PrinterStatus
        {
            get { return _PrinterStatus; }
            set { _PrinterStatus = value; }
        }



        public string Make
        {
            get { return _Make; }
            set { _Make = value; }
        }
        public int Paper
        {
            get { return _Paper; }
            set { _Paper = value; }
        }
        

    }
}
