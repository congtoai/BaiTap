using System;
using System.Drawing;

namespace GameDemo
{
    class Ship
    {
        private Point a;
        private Point b;
        private Point c; 
        public Ship() { }
        public void Nhap()
        {
            Console.WriteLine("Nhap toa do 3 diem cua con thuyen: ");
            Console.WriteLine("Diem 1:");
            nhaplai:
                a.X = Convert.ToInt32(Console.ReadLine());
                a.Y = Convert.ToInt32(Console.ReadLine());
                if (a.X < 0 || a.X > 4 || a.Y < 0 || a.Y > 4)
                {
                    Console.WriteLine("Nhap sai toa do, nhap lai: ");
                    goto nhaplai;
                }
            
            Console.WriteLine("Diem 2:");
            nhaplai2:
                b.X = Convert.ToInt32(Console.ReadLine());
                b.Y = Convert.ToInt32(Console.ReadLine());
            if (b.X < 0 || b.X > 4 || b.Y < 0 || b.Y > 4)
            {
                Console.WriteLine("Nhap sai toa do, nhap lai: ");
                goto nhaplai2;
            }
            Console.WriteLine("Diem 3:");
            nhaplai3:
            c.X = Convert.ToInt32(Console.ReadLine());
            c.Y = Convert.ToInt32(Console.ReadLine());
            if (c.X < 0 || c.X > 4 || c.Y < 0 || c.Y > 4)
            {
                Console.WriteLine("Nhap sai toa do, nhap lai: ");
                goto nhaplai3;
            }
        }
        public Point GetA()
        {
            return a;
        }
        public Point GetB()
        {
            return b;
        }
        public Point GetC()
        {
            return c;
        }

    }
}
