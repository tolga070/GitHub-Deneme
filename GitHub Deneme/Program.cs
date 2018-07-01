using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Deneme
{
    class Program
      
    {
        public static Random timer = new Random();

        static void Main(string[] args)
        {
            CanDEV.GUI();
            int bekleme = timer.Next(1000, 7000);
            

            Console.SetWindowSize(100, 30);
             Console.SetCursorPosition(20, 9);
            Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("> Acquiring signal... ");
            
            System.Threading.Thread.Sleep(bekleme);
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("> Signal acquired press 'Enter' to continue...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(1, 12);
            Console.WriteLine("> Hello! Can you hear me?");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("1 - Yes I can hear you || 2 - Who is this? ");

        int answer = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(1, 16);
            switch (answer)
            {
                case 1:
                    Console.WriteLine("> Oh! Thank god finally I have been trying to reach out to somebody for hours. Call me P.H.");
                    break;

                case 2:
                    Console.WriteLine("> My name is Phillip Hunter but you can call me P.H.");
                    break;
            }
            Console.SetCursorPosition(20, 18);
            Console.WriteLine("1 - Nice to meet you P.H. || 2 - Why did you call me? ");
            Console.ReadLine();

            Console.WriteLine(@"So I kinda need your help. I'm part of a research group and we are working on a project in the 
middle of nowhere. Problem is emergency alarms are going crazy so I'm suppose to leave the building
but the damndoor is stuck.");
            Console.WriteLine("1 - Well what do you have around you? || 2 - What do you want me to do? || 3 - Define nowhere. ");
           int answer2 = int.Parse(Console.ReadLine());
            switch (answer2)
            {
                case 1:
                    Console.WriteLine("I'm in a small room filled with my research papers and some chemicals");
                    break;
                case 2:
                    Console.WriteLine("placeholder");
                    break;
                case 3:
                    Console.WriteLine("That doesn't matter. I need help right now ");
                    break;
            }



           

        }
    }
    
}
