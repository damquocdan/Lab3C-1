using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car c=new car();
            c.make = "italy";
            c.year = 2010;
            c.model = "v1";
            c.color = "red";


            Console.WriteLine("Thông tin chi tiết");
            Console.WriteLine("make:" + c.make);
            Console.WriteLine("model:" + c.model);
            Console.WriteLine("color" + c.color);
            Console.WriteLine("year:" + c.year);
            c.start();
            c.stop();
            Console.ReadKey ();
        }
    }
}
