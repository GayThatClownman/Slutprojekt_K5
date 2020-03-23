using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt_K5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notes: Text-Based Dungeon Äventyr-kinda thing.
            
            int hp = 100;
            string gameState = "";

            /*int stateSwitch = 1;

            switch (stateSwitch)
            {
                case 1:
                    gameState = "Gamer";
                    break;
                case 2:
                    gameState = "Non-Gamer";
                    break;
            }

            while (gameState == "Gamer")
            {
                Console.WriteLine("Gamer");
                stateSwitch++;
                Console.ReadLine();
            }

            while (gameState == "Non-Gamer")
            {
                Console.WriteLine("Non-Gamer");
                stateSwitch--;
                Console.ReadLine();
            }*/

            /*List<string> weaponsList = new List<string>();*/

            /*string[] weaponsList =
            {
                "Wooden Shortsword", "", "", "", "",
            };*/

            bool checkGameCompletion = false;

            while (checkGameCompletion == false)
            {
                if (gameState == "intro")
                {

                }
            }

            if (checkGameCompletion == true)
            {
                Console.WriteLine("Wow, you made it. WhateverWhateverWhateverWhatever");
                
            }

            Console.ReadLine();

            
        }
    }
}
