using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Deneme
{
    class Program
      
    {


        static void Main(string[] args)
        {
            CanDEV.GUI();
            

            Console.SetWindowSize(125, 30);
             Console.SetCursorPosition(20, 9);
            Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("> Acquiring signal... ");
            
            System.Threading.Thread.Sleep(CanDEV.bekleme);
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("> Signal acquired press 'Enter' to continue...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(1, 12);
            Console.WriteLine("> Hello! Can you hear me?");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("1 - Yes I can hear you || 2 - Who is this? ");
        int answer = int.Parse(Console.ReadLine());
            CanDEV.Cevap();
            switch (answer)
            {
                case 1:
                    Console.WriteLine("> Oh! Thank god finally I have been trying to reach out to somebody for hours. Call me P.H.");
                    break;

                case 2:
                    Console.WriteLine("> My name is Phillip Hunter but you can call me P.H.");
                    break;
            }
            Console.SetCursorPosition(20, 11);
            Console.WriteLine("1 - Nice to meet you P.H. || 2 - Why did you call me? ");
            Console.ReadLine();
            System.Threading.Thread.Sleep(CanDEV.bekleme);
            Console.SetCursorPosition(1, 9);
            Console.WriteLine(@"> So I kinda need your help. I'm part of a research group and we are working on a project in the 
middle of nowhere. Problem is emergency alarms are going crazy so I'm supposed to leave the building
but the damndoor is stuck.");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("1 - Well what do you have around you? || 2 - What do you want me to do? || 3 - Define nowhere. ");
           int answer2 = int.Parse(Console.ReadLine());
            CanDEV.Cevap();
            switch (answer2)
            {
                case 1:
                    Console.WriteLine("I'm in a small room filled with my research papers my lucky pocket knife and a blow torch.");
                    goto arc1;
                    
                case 2:
                    Console.WriteLine("I don't know some advice would be nice.");
                    break;
                case 3:
                    Console.WriteLine("That doesn't matter. I need help your right now. Focus.");
                    Console.WriteLine("1 - Well what do you have around you ? || 2 - What do you want me to do?");
                    int answer2_2 = int.Parse(Console.ReadLine());
                    switch (answer2_2)
                    {
                        case 1:
                            Console.WriteLine("I'm in a small room filled with my research papers my lucky pocket knife and a blow torch.");
                            goto arc1;

                        case 2:
                            Console.WriteLine("I don't know some advice would be nice.");
                            break;
                    }
                            break;
            }

            arc1:
            Console.WriteLine("1 - What kind of chemicals? || 2 - Just kick the door or something ");
            int answer3 = int.Parse(Console.ReadLine());
            switch (answer3)
            {
                case 1:
                    Console.WriteLine("");
                    goto arc1;

                case 2:
                    Console.WriteLine("I don't know some advice would be nice.");
                    break;
                
            }



           

        }
    }
    
}
