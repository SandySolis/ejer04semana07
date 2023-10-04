using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer04semana07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingresa un número: ");
                int num=int.Parse(Console.ReadLine());
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num*2; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
