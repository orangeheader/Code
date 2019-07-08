using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n=0;
            int max;

            
             Console.WriteLine("Введите переменную а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную c");
            int c = int.Parse(Console.ReadLine());

            if (a == b & b == c)
                while (n < 3)
                {
                    n++;
                    Console.WriteLine("error вы ввели три одинаковых числа");
                    Console.WriteLine("Введите заново три числа");

                    Console.WriteLine("Введите переменную а");
                    a= int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите переменную b");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите переменную c");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите заново три числа");
                    Console.WriteLine("кол-во оставшихся попыток =" ,n);
                }

            else
            {
                if (a > b)
                    max = a;
                else
                    max = b;
                if (max > c)
                    Console.WriteLine(max);
                else
                    Console.WriteLine(c);
            }
        
            Console.ReadLine();
        }        


    }
}

