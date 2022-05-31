using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите первое число");
            int a = int.Parse (Console.ReadLine());
            Console.WriteLine("ВВедите второе число");
            int b = int.Parse (Console.ReadLine());
            Console.WriteLine("Введите операнд (/, +, -,*) выполняемой операции");
            char c = char.Parse (Console.ReadLine());
            var calculator = new Calculator();
            int res = 0;
            do
            {

                if (c == '/')
                {
                    res = calculator.Division(a, b);
                }
                if (c == '*')
                {
                    res = calculator.Miltiplication (a, b); 
                }
                if (c== '-')
                {
                    res = calculator.Subtraction(a, b);
                }
                if (c == '+')
                {
                    res = calculator.Additional(a, b);
                }


            }
            while (res == 0);
            Console.WriteLine(res);
        }
    }
}
