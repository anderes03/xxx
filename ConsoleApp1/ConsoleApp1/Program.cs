using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во градусов угла");
            string buf;
            buf = Console.ReadLine();
            double Grad;
            Grad = Convert.ToDouble(buf);
            Console.WriteLine("Введите кол-вог минут угла");
            string min;
            min = Console.ReadLine();
            double Minutes;
            Minutes = Convert.ToInt32(min);
            Console.WriteLine("Введите кол-во секунд угла");
            string sec;
            sec = Console.ReadLine();
            double Seconds;
            Seconds = Convert.ToInt32(sec);
            double Radians = 0;
            Radians = (Grad + Minutes / 60 + Seconds / 3600) * (Math.PI) / 180;
            if (Grad < 0)
                Radians = -Radians;
            Console.WriteLine("Значение данного угла в радианах =" + Radians);
            Console.ReadKey();
        }
    }
}
