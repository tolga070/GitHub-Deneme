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
                    Console.SetCursorPosition(18, 13);               
                    Console.WriteLine("1 - Well what do you have around you ? ");
                    int answer2_2 = int.Parse(Console.ReadLine());
                    CanDEV.Cevap();
                    switch (answer2_2)
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
                    int answer2_3 = int.Parse(Console.ReadLine());
                    CanDEV.Cevap();
                    switch (answer2_3)
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
                    System.Threading.Thread.Sleep(2000);
                    goto arc2;
                    
                

                case 2:
                    CanDEV.Cevap();
                    CanDEV.text ="> I'm not really a strong guy but I can give it a try.";
                    CanDEV.Yazı();
                    System.Threading.Thread.Sleep(2000);
                    Console.SetCursorPosition(1, 10);
                    CanDEV.text = "> Oof I springed off the door and twisted my ankle.";
                    CanDEV.Yazı();
                    CanDEV.Current_HP = CanDEV.Current_HP - 10;
                    Console.SetCursorPosition(1, 11);
                    CanDEV.text = "> My only option is to use the blowtorch now.";
                    CanDEV.Yazı();
                    System.Threading.Thread.Sleep(2000);
                    goto arc2;
            }


            arc2:
            CanDEV.Cevap();
            Console.SetCursorPosition(1, 9);        
            CanDEV.text = "> I used the blowtorch and it worked I broke the door. Hopefully they are not gonna make me pay for it.";
            CanDEV.Yazı();
            Console.SetCursorPosition(1, 10);
            CanDEV.text = "> Anyways I have to get out. I dont know what happened here but it smells terrible. Not gonna leave my knife behind though.";
            CanDEV.Yazı();
            CanDEV.weapon = "Pocketknife";          
            CanDEV.GUI();
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(1, 11);
            CanDEV.text = "> So I was heading towards the exit and then I heard a sound from one of the labs. Should I check out whats happening?";
            CanDEV.Yazı();
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("1 - Go to the exit you should have left the building already. || 2 - Of course somebody might be in danger. || 3 - I thought everybody left? ");

            int answer4 = int.Parse(Console.ReadLine());
            CanDEV.Cevap();
            switch (answer4)
            {
                case 1:
                    CanDEV.text = "> Yes you're right I should keep moving.";
                    CanDEV.Yazı();
                    goto exit;

                case 2:
                    CanDEV.text = "> well then P.H. to the rescue.";
                    CanDEV.Yazı();
                    goto rescue;
                    

                case 3:
                    CanDEV.text = "> Except the ones that are infected.";
                    CanDEV.Yazı();
                    Console.SetCursorPosition(20, 11);
                    Console.WriteLine("1 - What do you mean infected? || 2 - What kind of reasearch were you working on? ");
                    Console.ReadLine();
                    CanDEV.text = @"> It's a top secret research so I shouldn't talk about this but I was working on some kind of virus and I think somebody
 might have been infected.";
                    CanDEV.Yazı();
                    Console.SetCursorPosition(20, 11);
                    Console.WriteLine("1 - Then leave the building What are you waiting for? || 2 - You can't just leave him there. ");
                    int answer4_3 = int.Parse(Console.ReadLine());
                    CanDEV.Cevap();
                    switch (answer4_3)
                    {
                        case 1:
                            CanDEV.text = "> Yes you're right I should keep moving.";
                            CanDEV.Yazı();
                            goto exit;
                            
                        case 2:
                            CanDEV.text = "> well then P.H. to the rescue.";
                            CanDEV.Yazı();

                            goto rescue;                          
                    }
                    break;
            }
            rescue:
            System.Threading.Thread.Sleep(2000);
            Console.SetCursorPosition(1, 11);
            CanDEV.text = "> I looked through the window of the door and I saw someone in there but there is something weird about him. I'm not sure if I should go in.";
            CanDEV.Yazı();
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("1 - Screw it go to the exit. || 2 - Go in we can't leave him behind. || 3 - What do you mean weird ");
            int answer5 = int.Parse(Console.ReadLine());
            CanDEV.Cevap();
            switch (answer5)
            {
                case 1:
                    CanDEV.text = "> Yes you're right I should keep moving.";
                    CanDEV.Yazı();
                    goto exit;

                case 2:
                    CanDEV.text = "> Ok wish me luck.";
                    CanDEV.Yazı();
                    System.Threading.Thread.Sleep(2000);
                    CanDEV.text = "> Ahh he bit me.";
                    CanDEV.Yazı();
                    CanDEV.Current_HP = CanDEV.Current_HP - 20;
                    CanDEV.GUI();
                    Console.SetCursorPosition(20, 11);
                    Console.WriteLine("1 - What do you mean he bit you? || 2 - Are you okay?");
                    int answer5_2 = int.Parse(Console.ReadLine());
                    CanDEV.Cevap();
                    switch (answer5_2)
                    {
                       case 1:
                            CanDEV.text = @"> As soon as I went inside he jumped on me and bit my arm. I managed to stab him and ran away but he kept chasing me so I 
went inside the staff room and locked the door behind me I think he is still at other side of the door trying to get in. So much for heroism.";
                            CanDEV.Yazı();
                            break;
                    }
                    break;
            }
            

            exit:
            Console.WriteLine("placeholder");
            




        }
    }
    
}
