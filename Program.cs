using System;
using System.Collections.Generic;

namespace Queues_Wilson_Kenny
{


    /// <summary>
    /// Class Called my and new Player 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(60, 59);

            Queue<Player> waitingToJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "MMSix");
            Player p2 = new Player(100, "xXAwsomenessXx");
            Player p3 = new Player(100, "Get Good");
            Player p4 = new Player(100, "ZombieSlaya");



            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("Players in da Q");
            foreach(Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);


            Console.WriteLine("\nPlayers in da Q");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}