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
            
            //Olika variabler för spelar-hp och damagevärden. Gamestate är en kvarleva från tidigare tankar till projektet, som inte har mycket använding något mer.
            int hp = 100;
            string gameState = "gameStart";
            string action = "";
            int damage = 0;
            int enemyDamage = 0;

            //Variabel som kollar vilken nivå som man har nått, som *skulle* styra flera aspekter av spelet.
            int stage = 1;

            //Int-Array som ska motsvara livet på fienden beroende på level.
            int[] enemyHealth =
            {
                10, 25, 50, 75, 100, 150,
            };

            //String-array av vapen som skulle vara tillgängliga i shopen, som ens Damage-värden skulle bestämmas utifrån
            string[] weaponsList =
            {
                "Wooden Shortsword", "1", "2", "3", "4",
            };

            string currentWeapon = weaponsList[0];

            //Bool som kollar om spelet är avklarat eller inte. Tänkt för att kunna ge spelaren en End-Screen
            bool checkGameCompletion = false;

            while (checkGameCompletion == false)
            {
                
                while (gameState == "gameStart")
                {

                    if (stage == 1 && enemyHealth[0] > 0)
                    {
                        //Skriver ut livet av fiende, spelarens alternativ och tar emot spelar val.
                        Console.WriteLine("Current enemy health: " + enemyHealth[0]);
                        FightPrompt();
                        //Navigate(action);
                        action = Console.ReadLine().ToLower();

                        //Om spelaren valde alternativ A så genereras ett tal som skada som fienden tar. Efter det gör detsamma från fiendens sida. Detta repeteras tills fienden är har förlorat all HP.
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

                        //Om spelaren valde alternativ C så avslutas programmet.
                        if (action == "c")
                        {
                            Environment.Exit(0);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Funkar inte.");
                    }
                }
           
            }

            if (checkGameCompletion == true)
            {
                Console.WriteLine("Wow, you made it. WhateverWhateverWhateverWhatever");
                
            }

            Console.ReadLine();

            
        }
        //Metod som skriver ut de olika valen man har under en fight.
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

        //Metod som genererar ett tal utifrån två variabler.
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
