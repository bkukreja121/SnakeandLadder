using System;

namespace SnakeAndLadder
{
    class Program : Snake
    {


        static void Main(string[] args)
        {
            // three players statarting on square one
            int[] players = { 1, 1, 1 };
            while (true)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    int ns = Turn(i + 1, players[i]);
                    if (ns == 100)
                    {
                        Console.WriteLine("Player {0} wins!", i + 1);
                        return;
                    }
                    players[i] = ns;
                    Console.WriteLine();
                }
            }
        }
    }
}