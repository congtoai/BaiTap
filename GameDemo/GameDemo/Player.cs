using System;
using System.Drawing;
using System.Collections;
namespace GameDemo
{
    class Player:Map
    {
        protected Point point;
        Hashtable ht = new Hashtable();
        int t = 0;
        public Player() { }
        public void Play()
        {
          
            nhaplai:
            Console.WriteLine("Nhap toa do diem ban: ");
            point.X = Convert.ToInt32(Console.ReadLine());
            point.Y = Convert.ToInt32(Console.ReadLine());

            if (point.X < 0 || point.X > 4 || point.Y < 0 || point.Y > 4)
            {
                Console.WriteLine("nhap sai toa do,nhap lai:");
                goto nhaplai;
            }
            if (ht.ContainsValue(point))
            {
                Console.WriteLine("diem nay da ban roi:");
                goto nhaplai;
            }
            else
            {
                ht.Add(t + 1, point);
            }
            t = t + 1;

        }
        public Point GetPoint()
        {
            return point;
        }

    }
}
