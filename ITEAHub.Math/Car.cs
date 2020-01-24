using System;
using System.Collections.Generic;
using System.Text;

namespace ITEAHub.Math
{
    public class Car
    {
        public static string Model { get; set; }

        public Car()
        {
            Console.WriteLine("Norm cstr");
        }

        static Car()
        {
            Console.WriteLine("Static const");
        }

      



    }
}
