using System;
using System.Collections.Generic;
using System.Text;

namespace ITEAHub.Math
{
    class Matrix
    {
        private int N;
      

        private int[] arr;

        public int Max
        {
            get
            {
                return MaxItem();
            }
        }

        public Matrix(int n, int m)
        {
            arr = new int[n];
            N = n;
        }
        public Matrix(int n)
        {
            this.N = n;
        }


        public void Input()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{i}=");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        public void Print()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arr[i]} ");

            }
        }

        public bool Exist(int num)
        {
            return true;
        }

        private int MaxItem()
        {
            return arr[0];
        }

 


    }
}
