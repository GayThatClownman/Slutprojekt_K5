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
            //Notes: Stage-based Fight Spel med progressive scaling..
            
            int hp = 100;
            string gameState = "gameStart";
            int damage = DamageGenerator(5, 15);

            int stage = 1;

            int[] enemyHealth =
            {
                10, 25, 50, 75, 100, 150,
            };

            string[] weaponsList =
            {
                "Wooden Shortsword", "", "", "", "",
            };

            bool checkGameCompletion = false;

            while (checkGameCompletion == false)
            {
                /*if (gameState == "intro")
                {
                    Intro();
                    
                    gameState = "gameStart";                    
                }*/

                while (gameState == "gameStart")
                {
                    if (stage == 1)
                    {
                        Console.WriteLine("Okdog");
                    }

                    else
                    {
                        Console.WriteLine("Bruh tf");
                    }
                }

                /*if (gameState == "test")
                {
                    //damage = DamageGenerator(125, 200);
                    //Console.WriteLine(damage);
                    Console.WriteLine("OkDog");
                    Console.ReadLine();
                }*/                
            }

            if (checkGameCompletion == true)
            {
                Console.WriteLine("Wow, you made it. WhateverWhateverWhateverWhatever");
                
            }

            Console.ReadLine();

            
        }

        static void FightPrompt()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("A: Attack");
            Console.WriteLine("B: Block");
            //Console.ReadLine();
            /*gameState = Console.ReadLine().ToLower();
            return gameState;*/
        }



        /*static string Navigate()
        {
            string nav = "";
            nav = Console.ReadLine().ToLower();
            return nav;
        }*/

        static int DamageGenerator(int dmg1, int dmg2)
        {
            Random dmgGenerator = new Random();

            int damage = dmgGenerator.Next(dmg1, dmg2);

            return damage;
        }

        static void AttackPhase(int[] enemyHealth, int stage)
        {

        }


    }
}
