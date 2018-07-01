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

           Console.SetWindowSize(60, 35);
           
            Console.WriteLine("> ");
            Console.SetCursorPosition(16, 9);

            Console.WriteLine("Hello! Can you hear me?");
            Console.WriteLine("1 - Yes I can hear you || 2 - Who is this? ");
            int answer1 = int.Parse(Console.ReadLine());

            
            switch (answer1)
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


            //int luck = CanDEV.Zar();
            //int luck2 = CanDEV.Zar();
            //if (luck2 == luck)
            //{
            //    luck2 = CanDEV.Zar();
            //}

        }
    }
    
}
