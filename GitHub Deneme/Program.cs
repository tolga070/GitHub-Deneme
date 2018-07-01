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
            int luck = CanDEV.Zar();
            int luck2 = CanDEV.Zar();
            if (luck2 == luck)
            {
                luck2 = CanDEV.Zar();
            }
        }
    }
}
