using System;
using System.Drawing;
using System.Collections;
namespace GameDemo
{
    
    class Game:Player
    {
        private int n=3;
        private int n1=3;
        Player player1 = new Player();
        Player player2 = new Player();
        public Game()
        {
            
            
        }
        public void start()
        {
            Console.WriteLine("*********        Cai Dat Nguoi Choi        ******");
            Console.WriteLine("Nguoi choi 1: ");
            player1.Nhap();
            player1.PrintBoard();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nguoi choi 2: ");
            player2.Nhap();
            player2.PrintBoard();
            Console.WriteLine("************** BAT DAU CHOI ************");

            banlai:
            Console.WriteLine("Den luot nguoi choi 1:");
            player1.Play();
            if (player1.GetPoint() == player2.GetA() ||
               player1.GetPoint() == player2.GetB() ||
               player1.GetPoint() == player2.GetC())
            {
                Console.WriteLine("Chuc mung ban da ban trung thuyen dich: ");
                player1.PrintBoard(player1.GetPoint(), 1);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine();
                n--;
                if (n == 0)
                {
                    Console.WriteLine("You win: ");
                    goto Gameover;
                }
            }
            else if (player1.GetPoint() == player1.GetA() ||
                       player1.GetPoint() == player1.GetB() ||
                       player1.GetPoint() == player1.GetC())
            {
                Console.WriteLine("khong duoc ban vao thuyen cua minh: ban lai");
                goto banlai;
            }
            else
            {
                Console.WriteLine("HUHU: Ban xit roi ");
                player1.PrintBoard(player1.GetPoint(),2);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine();
            }


            banlai1:
            Console.WriteLine("Den luot nguoi choi 2:");
            player2.Play();
            if (player2.GetPoint() == player1.GetA() ||
                player2.GetPoint() == player1.GetB() ||
                player2.GetPoint() == player1.GetC())
            {
                Console.WriteLine("Chuc mung ban da ban trung thuyen dich: ");
                player2.PrintBoard(player2.GetPoint(), 1);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine();
                n1--;
                if (n1 == 0)
                {
                    Console.WriteLine("You win: ");
                    goto Gameover;
                }
            }

            else if (player2.GetPoint() == player2.GetA() ||
                    player2.GetPoint() == player2.GetB() ||
                    player2.GetPoint() == player2.GetC())
            {
                Console.WriteLine("khong duoc ban vao thuyen cua minh: ban lai");
                goto banlai1;
            }
            else
            {
                Console.WriteLine("HUHU: Ban xit roi ");
                player2.PrintBoard(player2.GetPoint(),2);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine();
            }
            goto banlai;
            Gameover:
            Console.WriteLine("---------------------------------------------------------------------");
        }
        
           
        
    }
}
