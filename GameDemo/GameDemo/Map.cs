using System;
using System.Drawing;

namespace GameDemo
{
    class Map : Ship
    {

        public string[,] arr;

        public Map()
        {
            
            arr = new string[5, 5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = "-";
                }
            }
        }
        public void PrintBoard()
        {

            arr[GetA().X, GetA().Y] = "x";
            arr[GetB().X, GetB().Y] = "x";
            arr[GetC().X, GetC().Y] = "x";
            Console.WriteLine("    0   1   2   3   4");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(i);
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void PrintBoard(Point point, int x)
        {
            if(x == 1)
            {
                arr[point.X, point.Y] = "T";
            }
            if(x == 2)
            {
                arr[point.X, point.Y] = "M";
            }
            arr[GetA().X, GetA().Y] = "x";
            arr[GetB().X, GetB().Y] = "x";
            arr[GetC().X, GetC().Y] = "x";
          
            Console.WriteLine("    0   1   2   3   4");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(i);
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
