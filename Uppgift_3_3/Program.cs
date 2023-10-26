using System;

namespace Uppgift_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen? svara i antal timmar.");
            string timmar = (Console.ReadLine());
            int antal_timmar = int.Parse(timmar);
            int svar = (antal_timmar * 80);
            if (svar >= 950)
            {
                Console.WriteLine("kostnad för " + timmar + " timmar är 950 kr ");

            }
            else
            {
                 Console.WriteLine("Kostnad för" + timmar + " timmar är " + svar);
            }







        }
    }
}


