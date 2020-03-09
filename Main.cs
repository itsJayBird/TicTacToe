using System;

namespace C__Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean again = false;
            do{
                Game a = new Game();
                a.startGame();
                Console.WriteLine("Play Again? Y/N");
                String ans = Console.ReadLine();
                if(ans=="N" || ans=="n")again = true;
                Console.Clear();
            }while(again==false);
         }
    }
}
