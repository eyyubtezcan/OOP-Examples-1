using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraton_Part04
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr1 = new User("Eyyüb","123456");
         
           Console.WriteLine("User Name : {0} User Pass : {1}",usr1.UserName,usr1.UserPass);
            Console.ReadLine();
        }
    }
}
