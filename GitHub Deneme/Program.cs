﻿using System;
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
            CanDEV.text = "> Hello! Can you hear me?";
            CanDEV.Yazı();
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("1 - Yes I can hear you || 2 - Who is this? ");
        int answer = int.Parse(Console.ReadLine());
            CanDEV.Cevap();
            switch (answer)
            {
                case 1:
                    CanDEV.text = "> Oh! Thank god finally I have been trying to reach out to somebody for hours. Call me P.H.";
                    break;

                case 2:
                    CanDEV.text = "> My name is Phillip Hunter but you can call me P.H.";
                    break;
            }
            CanDEV.Yazı();
            Console.SetCursorPosition(20, 11);
            Console.WriteLine("1 - Nice to meet you P.H. || 2 - Why did you call me? ");
            Console.ReadLine();
            Console.Clear();
            CanDEV.GUI();
            Console.SetCursorPosition(1, 9);
            CanDEV.text = @"> So I kinda need your help. I'm part of a research group and we are working on a project in the 
middle of nowhere. Problem is emergency alarms are going crazy so I'm supposed to leave the building
but the damned door is stuck.";
            CanDEV.Yazı();
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("1 - Well what do you have around you? || 2 - What do you want me to do? || 3 - Define nowhere. ");

           int answer2 = int.Parse(Console.ReadLine());
            CanDEV.Cevap();
            switch (answer2)
            {
                case 1:
                    CanDEV.text = "> I'm in a small room filled with my research papers my lucky pocket knife and a blow torch.";
                    CanDEV.Yazı();
                    goto arc1;
                    
                case 2:
                    CanDEV.text ="> I don't know some advice would be nice.";
                    CanDEV.Yazı();
                    advice:
                    Console.SetCursorPosition(20, 11);               
                    Console.WriteLine("1 - Well what do you have around you ? ");
                    int answer2_1 = int.Parse(Console.ReadLine());
                    CanDEV.Cevap();
                    switch (answer2_1)
                    {
                        case 1:
                            CanDEV.text = "> I'm in a small room filled with my research papers my lucky pocket knife and a blow torch.";
                            CanDEV.Yazı();
                            goto arc1;
                    }
                    break;
                case 3:
                    CanDEV.text = "> That doesn't matter. I need your help right now. Focus.";
                    CanDEV.Yazı();

                    Console.SetCursorPosition(20, 11);
                    Console.WriteLine("1 - Well what do you have around you ? || 2 - What do you want me to do?");
                    int answer2_2 = int.Parse(Console.ReadLine());
                    CanDEV.Cevap();
                    switch (answer2_2)
                    {
                        case 1:
                            CanDEV.text ="> I'm in a small room filled with my research papers my lucky pocket knife and a blow torch.";
                            CanDEV.Yazı();
                            goto arc1;

                        case 2:
                            CanDEV.text ="> I don't know some advice would be nice.";
                            CanDEV.Yazı();
                            goto advice;
                            
                    }
                            break;
            }

            arc1:
            Console.SetCursorPosition(20, 11);
            Console.WriteLine("1 - Did you try using the blowtorch on the door? || 2 - Just kick the door or something ");
            
            int answer3 = int.Parse(Console.ReadLine());
            switch (answer3)
            {
                case 1:
                    CanDEV.Cevap();
                    CanDEV.text ="> That sounds too dangerous but desperate times call for deperate measures.";                    
                    CanDEV.Yazı();
                    goto arc2;
                    
                

                case 2:
                    CanDEV.Cevap();
                    CanDEV.text ="> I'm not really a strong guy but I can give it a try.";
                    CanDEV.Yazı();
                    Console.SetCursorPosition(1, 10);
                    CanDEV.text = "> Oof I springed off the door and twisted my ankle.";
                    CanDEV.Yazı();
                    CanDEV.Current_HP = CanDEV.Current_HP - 10;
                    Console.SetCursorPosition(1, 11);
                    CanDEV.text = "> My only option is to use the blowtorch now.";
                    CanDEV.Yazı();
                    goto arc2;
            }


            arc2:
            CanDEV.Cevap();
            Console.SetCursorPosition(1, 9);
            CanDEV.text = "> I used the blowtorch and it worked I broke the door. Hopefully they are not gonna make me pay for it.";
            CanDEV.Yazı();
            Console.SetCursorPosition(1, 10);
            CanDEV.text = "> Anyways I have to get out. I dont know what happened here but it smells terrible.";
            CanDEV.Yazı();
            Console.ReadLine();






        }
    }
    
}
