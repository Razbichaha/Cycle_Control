using System;

namespace Cycle_Control
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string cycleShutdownWord = "exit";
            bool flag = true;

            while(flag)
            {
                 Console.WriteLine("Для останова программы наберите exit");
                string temp = Console.ReadLine();
                if(temp.Equals(cycleShutdownWord))
                {
                    flag = false;
                    Console.WriteLine("Подтвержден выход из цикла");
                }
            }
        }
    }
}
