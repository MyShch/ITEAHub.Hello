using System;

namespace ITEAHub.Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Yuhu!");

            Console.WriteLine(Math(5));

            Console.ReadKey();
        }


        static int Math(int a)
        {
         
            if(a == 0)
            {
                return 1;
            }
            else
            {
                return a * Math(a - 1);
            }
        }


    }
}

