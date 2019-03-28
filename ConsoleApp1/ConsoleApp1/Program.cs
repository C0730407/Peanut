using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gagan rules the IT universe");Download();
        }

        static void Download()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Download Complete");
            Console.ReadLine();
        }
    }
}
