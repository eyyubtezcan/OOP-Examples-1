using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton_Part04
{
    class User
    {
     
        

        public User(string username,string userpass)
        {
            _UserName = username;
            _UserPass=userpass;
        }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
        }
        private string _UserPass;
        public string UserPass
        {
            get
            {
                int i= 0;
                string val = "";
                while (i < _UserPass.Length)
                {
                    val += "*";
                    i++;
                }
                return val;
            }
        }

    }
}
