using System;

namespace Cycle_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            string cycleShutdownWord = "exit";
            bool disableCycle = true;

            while(disableCycle)
            {
                 Console.WriteLine("Для останова программы наберите exit");

                if(Console.ReadLine().Equals(cycleShutdownWord))
                {
                    disableCycle = false;
                    Console.WriteLine("Подтвержден выход из цикла");
                }
            }
        }
    }
}
