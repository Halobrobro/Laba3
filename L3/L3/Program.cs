using System;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {


<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            double a;
            Console.WriteLine("Введите А: ");
            a = Convert.ToDouble(Console.ReadLine());
=======
            
            double b;
            Console.WriteLine("Введите B: ");
            b = Convert.ToDouble(Console.ReadLine());
           
           
=======
            char c;
            double d;

            Console.WriteLine("Введите знак");
            Console.WriteLine("-");

            c = Convert.ToChar(Console.ReadLine());
            if (c == '-')
            {
                d = a - b;
            }

>>>>>>> minus

>>>>>>> B
=======
            
            char c;
            double d;
        
            Console.WriteLine("Введите знак");
            Console.WriteLine("+");

            c = Convert.ToChar(Console.ReadLine());
            if (c == '+')
            {
                d = a + b;
            }
>>>>>>> +
        }
    }
}