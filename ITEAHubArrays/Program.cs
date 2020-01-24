using System; 

namespace ITEAHubArrays
{
    class Program
    {
        const int column = 2;
        const int row = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[,] coordinates = ReadPoints();




            
           
            Console.ReadKey();
        }

        static int[,] ReadPoints(int row, int column)
        {
            int[,] points = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                Console.Write($"x{i+1} = ");
                var tempX = Console.ReadLine();

                Console.Write($"y{i+1} = ");
                var tempY = Console.ReadLine();

                if(!int.TryParse(tempX, out points[i, 0]) || 
                    !int.TryParse(tempY, out points[i, 1]))
                {
                    Console.WriteLine("Incorect data");
                }
            }


            return points;
        }

        static int[] CalcLenghts(int[,] point)
        {
            int[] lenghts = new int[row];





            return lenghts;
        }

        static CalcLine(int x1, int y1)
        {

        }

    }
}
