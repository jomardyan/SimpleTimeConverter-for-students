using System;

namespace mintst
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write seconds");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(calcmin(y));
        }

        static string calcmin(int seconds)
        {
            int Minutes = 0, Seconds = 0;
            int i = seconds;
            if (seconds < 60)
            {
                Seconds = seconds;
            }
            else if (seconds > 60)
            
            {
                i = seconds % 60;
                Minutes = (seconds - i) / 60;
                Seconds = seconds;
            }

            return "Min: " + Minutes.ToString() + " Seconds: " + i;
        }

    }
}
