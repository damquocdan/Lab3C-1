using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C_
{
    internal class car
    {
        //khai báo các trường với phạm vi public
        public string make;
        public string model;
        public string color;
        public int year;
        //Định nghĩa phương thức start
        public void start ()
        {
            Console.WriteLine(model +"Khoi dong");
        }
        //Định nghĩa phương thức stop
        public void stop()
        {
            Console.WriteLine(model+ "Khoi dong");
        }
    }
}
