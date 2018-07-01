using System;
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


        public static void GUI()
        {
            //GUI

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(10, 0);
            Console.WriteLine(" ________________________________________________________________");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine(" ----------------------------------------------------------------");
            for (int a = 1; a <= 6; a++)
            {
                Console.SetCursorPosition(11, a);
                Console.WriteLine("|");
                Console.SetCursorPosition(74, a);
                Console.WriteLine("|");
            }
            //HUD

            Console.SetCursorPosition(35, 2);
            Console.WriteLine("-PLACEHOLDER-");
            Console.SetCursorPosition(15, 5);
            Console.WriteLine("Health: {0}/{1}", Max_HP , Current_HP);
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("Supplies: {0}", supply );
            Console.SetCursorPosition(55, 5);
            Console.WriteLine("Weapon: {0}", weapon);

        }

        public static int Zar()
        {
            int şans = zar.Next(1, 7);
            Console.WriteLine("You've rolled ~ {0} ~ ", şans);
            return şans;
        }
    }
}
