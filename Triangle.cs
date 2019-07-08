//Программа для определения типа треугольника
//Программист Сабиров Дмитрий Эдуардович
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("enter a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c");
            c = int.Parse(Console.ReadLine());
            if (a <= 0 && b <= 0 && c <= 0)
              { Console.WriteLine("error,incored numbers");
                Console.ReadKey();
                return;
              }
            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("error,incored numbers");
                Console.ReadKey();
                return;
            }
            if (a == b && b == c)
             Console.WriteLine("equilateral triangle");
                else if (a == b || b == c || c == a)
                    Console.WriteLine("eisosceles triangle");
                else if (a * a == (b * b) + (c * c) || b * b == (a * a) + (c * c) || c * c == (a * a) + (b * b))
                    Console.WriteLine("right triangle");
                else Console.WriteLine("other triangle");
            
                Console.ReadKey();
            

        }
    }
}
