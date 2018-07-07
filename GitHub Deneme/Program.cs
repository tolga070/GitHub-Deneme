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
            //adamın konuşmasında kimyasal yok ama cevapta kimyasal var , case 2 ile arc1'e direk bağlanıyor , answer2_2deki case 2 de aynı durum
            switch (answer2)
            {
                case 1:
                    CanDEV.text = "I'm in a small room filled with my research papers my lucky pocket knife and a blow torch.";
                    CanDEV.Yazı();
                    goto arc1;
                    
                case 2:
                    CanDEV.text ="I don't know some advice would be nice.";
                    CanDEV.Yazı();
                    break;
                case 3:
                    CanDEV.text = "That doesn't matter. I need help your right now. Focus.";
                    CanDEV.Yazı();
                    Console.SetCursorPosition(20, 11);
                    Console.WriteLine("1 - Well what do you have around you ? || 2 - What do you want me to do?");
                    int answer2_2 = int.Parse(Console.ReadLine());
                    CanDEV.Cevap();
                    switch (answer2_2)
                    {
                        case 1:
                            CanDEV.text ="I'm in a small room filled with my research papers my lucky pocket knife and a blow torch.";
                            CanDEV.Yazı();
                            goto arc1;

                        case 2:
                            CanDEV.text ="I don't know some advice would be nice.";
                            CanDEV.Yazı();
                            break;
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
                    CanDEV.text ="That sounds too dangerous but desperate times call for deperate measures.";
                    goto arc2;
                    CanDEV.Yazı();
                

                case 2:
                   CanDEV.text ="I'm not really a strong guy but I can give it a try";
                    CanDEV.Yazı();
                    break;
                
            }



           

        }
    }
    
}
