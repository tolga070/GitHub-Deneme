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
           
            int bekleme = timer.Next(1000, 7000);
            

            Console.SetWindowSize(100, 30);
             Console.SetCursorPosition(16, 9);
        Console.WriteLine("> Acquiring signal... ");
            
            System.Threading.Thread.Sleep(bekleme);

            Console.WriteLine("> Signal acquired press any key to continue...");
            Console.ReadKey();

           
            Console.WriteLine("Hello! Can you hear me?");
            Console.WriteLine("1 - Yes I can hear you || 2 - Who is this? ");

        int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Oh! Thank god finally I have been trying to reach out to somebody for hours. Call me P.H.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("My name is Phillip Hunter but you can call me P.H.");
                    Console.ReadKey();
                    break;
            }


            Console.WriteLine("1 - Nice to meet you P.H. || 2 - Why did you call me? ");
            Console.ReadLine();

            Console.WriteLine("So I kinda need your help. I'm part of a research group and we are working on a project in the middle of nowhere");
            
          


            //int luck = CanDEV.Zar();
            //int luck2 = CanDEV.Zar();
            //if (luck2 == luck)
            //{
            //    luck2 = CanDEV.Zar();
            //}

        }
    }
    
}
