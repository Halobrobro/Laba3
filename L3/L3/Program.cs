using System;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите А: ");
            a = Convert.ToDouble(Console.ReadLine());
            char c;
            double d;

            double b;
            Console.WriteLine("Введите B: ");
            b = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Введите знак");
            Console.WriteLine("-");
            Console.WriteLine("+");
            Console.WriteLine("/");
            Console.WriteLine("*");
            c = Convert.ToChar(Console.ReadLine());
            if (c == '/')
            {
                if(b==0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                else
                {
                    d = a / b;
                }
            }
            if (c == '-')
            {
                d = a - b;
            }
            if (c == '+')
            {
                d = a + b;
            }
            if (c == '*')
            {
                d = a * b;
            }
        }
    }
}
