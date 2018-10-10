#define SHOWERROR

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcomeMessage;

#warning a sample custom warning message

//#if SHOWERROR
//#error SHOWERROR is defined
//#endif

            Console.WriteLine("Enter your name");
            string yourName = Console.ReadLine();
            Console.WriteLine(string.Format("Hello {0}!!! Welcome to Visual Studio.", yourName));
            Console.ReadLine();
        }
    }
}
