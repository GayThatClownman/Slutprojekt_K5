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
            string gameState = "intro";
            int damage = 0;

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
                    Intro();
                    gameState = "test";
                }

                if (gameState == "test")
                {
                    //damage = DamageGenerator(125, 200);
                    //Console.WriteLine(damage);

                    Console.ReadLine();
                }
            }

            if (checkGameCompletion == true)
            {
                Console.WriteLine("Wow, you made it. WhateverWhateverWhateverWhatever");
                
            }

            Console.ReadLine();

            
        }

        static string Intro()
        {
            string state = "test";

            Console.WriteLine("This is an intro screen.");
            Console.WriteLine("Wow, how EPIC!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            return state;
        }

        static int DamageGenerator(int dmg1, int dmg2)
        {
            Random dmgGenerator = new Random();

            int damage = dmgGenerator.Next(dmg1, dmg2);

            return damage;
        }


    }
}
