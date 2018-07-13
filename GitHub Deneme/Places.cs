using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Deneme
{

    class Places
    {
        public static Random dice = new Random();

        public static int Zar2()
        {
            int şans = dice.Next(1, 7);
            return şans;
        }
        //sendeki aynı değil mergelemeden değişikllik yapmışsın
        public static int Mekan()
        {
            int sayı1 = Zar2();
            int sayı2 = Zar2();
            int sayı3 = Zar2();
            int sayı4 = Zar2();
            int sayı5 = Zar2();
            int sayı6 = Zar2();
            while (sayı2 == sayı1)
            {
                sayı2 = Zar2();
            }
            while (sayı3 == sayı1 || sayı3 == sayı2)
            {
                sayı3 = Zar2();
            }
            while (sayı4 == sayı1 || sayı4 == sayı2 || sayı4 == sayı3)
            {
                sayı4 = Zar2();
            }
            while (sayı5 == sayı1 || sayı5 == sayı2 || sayı5 == sayı3 || sayı5 == sayı4)
            {
                sayı5 = Zar2();
            }
            while (sayı6 == sayı1 || sayı6 == sayı2 || sayı6 == sayı3 || sayı6 == sayı4 || sayı6 == sayı5)
            {
                sayı6 = Zar2();
            }

            Console.WriteLine(sayı1);
            Console.WriteLine(sayı2);
            Console.WriteLine(sayı3);
            Console.WriteLine(sayı4);
            Console.WriteLine(sayı5);
            Console.WriteLine(sayı6);
            return sayı1;
        }


        public static void GasStation()
        {

        }
        public static void GasStation1()
        {

        }
        public static void GasStation2()
        {

        }
        public static void GasStation3()
        {

        }
        public static void GasStation4()
        {

        }
        public static void GasStation5()
        {

        }
    }
}
