using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            string action = "";
            int damage = 0;
            int enemyDamage = 0;

            int stage = 1;

            int[] enemyHealth =
            {
                10, 25, 50, 75, 100, 150,
            };

            string[] weaponsList =
            {
                "Wooden Shortsword", "1", "2", "3", "4",
            };

            string currentWeapon = weaponsList[0];

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

                    if (stage == 1 && enemyHealth[0] > 0)
                    {
                        
                        Console.WriteLine("Current enemy health: " + enemyHealth[0]);
                        FightPrompt();
                        //Navigate(action);
                        action = Console.ReadLine().ToLower();

                        if (action == "a")
                        {
                            damage = DamageGenerator(1, 5);
                            enemyHealth[0] = enemyHealth[0] - damage;
                            Console.WriteLine("You strike the enemy, dealing " + damage + " damage.");
                            Thread.Sleep(1500);
                            enemyDamage = DamageGenerator(4, 8);
                            hp = hp - enemyDamage;
                            Console.WriteLine("The enemy strikes you, dealing " + enemyDamage + " damage.");
                            Thread.Sleep(1500);

                        }

                        if (action == "c")
                        {
                            Environment.Exit(0);
                        }
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
            string[] choices =
            {
                "A: Attack",
                "B: Block",
                "C: Exit"
            };

            int nmr = 0;

            Console.WriteLine("What do you want to do?");
            while (nmr < choices.Length)
            {
                Console.WriteLine(choices[nmr]);
                nmr++;
            }
            
        }

        /*static string Navigate(string action)
        {
            action = Console.ReadLine().ToLower();
            return action;
        }*/

        static int DamageGenerator(int dmg1, int dmg2)
        {
            Random dmgGenerator = new Random();

            int damage = dmgGenerator.Next(dmg1, dmg2);

            return damage;
        }

        static void PlayerAttackPhase(int[] enemyHealth, int damage)
        {
            
        }


    }
}
