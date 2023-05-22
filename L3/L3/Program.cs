using System;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {


            char c;
            double d;

            Console.WriteLine("Введите знак");
            Console.WriteLine("/");

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


        }
    }
}