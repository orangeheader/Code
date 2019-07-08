//Нахождения дискриминанта 
//Программист Сабиров Дмитрий Эдуардович
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            double x1, x2, x3;
            x3 = 0;
            x1 = 0;
            x2 = 0;
            Console.WriteLine("Enter a ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c ");
            c = double.Parse(Console.ReadLine());
            d = ((b * b) - (4 * a * c));

            if (d < 0)

                Console.WriteLine("no sqrt");



            else if (d == 0)
            {
                x3 = (-b / (2 * a));
                Console.WriteLine(x3);
            }
            else if (d > 0)
            {

                x1 = ((-b + Math.Sqrt(d)) / (2 * a));
                x2 = ((-b - Math.Sqrt(d)) / (2 * a));

                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            Console.ReadKey();




        }
        
    }
}