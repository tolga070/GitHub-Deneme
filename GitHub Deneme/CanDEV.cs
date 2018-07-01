﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Deneme
{
    public class CanDEV
    {
        public static int Max_HP = 100;
        public static int Current_HP = 100;
        public static int supply = 0;
        public static string weapon = "fists";
        public static Random zar = new Random();
        public static Random timer = new Random();
        public static int bekleme = timer.Next(1000, 7000);


        public static void GUI()
        {
            //GUI

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(30, 0);
            Console.WriteLine(" ________________________________________________________________");
            Console.SetCursorPosition(30, 7);
            Console.WriteLine(" ----------------------------------------------------------------");
            for (int a = 1; a <= 6; a++)
            {
                Console.SetCursorPosition(31, a);
                Console.WriteLine("|");
                Console.SetCursorPosition(94, a);
                Console.WriteLine("|");
            }
            //HUD

            Console.SetCursorPosition(55, 2);
            Console.WriteLine("-PLACEHOLDER-");
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("Health: {0}/{1}", Max_HP , Current_HP);
            Console.SetCursorPosition(55, 5);
            Console.WriteLine("Supplies: {0}", supply );
            Console.SetCursorPosition(75, 5);
            Console.WriteLine("Weapon: {0}", weapon);

        }

        public static int Zar()
        {
            int şans = zar.Next(1, 7);
            Console.WriteLine("You've rolled ~ {0} ~ ", şans);
            return şans;
        }
        
        public static void Cevap()
        {
            System.Threading.Thread.Sleep(bekleme);
            Console.Clear();
            CanDEV.GUI();
            Console.SetCursorPosition(1, 9);
        }
    }
}
