using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пробная публикация проекта
            /*
            //13.9
            Console.Write("N = ");
            int.TryParse(Console.ReadLine(), out int n);
            int[] x = new int[n];
            Random rand = new Random();
            FileStream f = new FileStream("f.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            for (int i = 0; i < n; i++)
            {
                x[i] = rand.Next(10);
                sw.WriteLine(x);
                Console.Write($"{x[i]} ");
            }
            Console.WriteLine();
            Console.Write("k = ");
            int.TryParse(Console.ReadLine(), out int k);
            FileStream g = new FileStream("g.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(g);
            for (int i = 0; i<n; i++)
            {
                if(x[i]%k != 0)
                {
                    x[i] = x[i];
                    sw.WriteLine(x);
                    Console.Write($"{x[i]} ");
                }
            }*/





            //задача для практики
            Random rand = new Random();
            int a = rand.Next(10);
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("b = ");
                int.TryParse(Console.ReadLine(), out int b);
                if (b > a)
                {
                    Console.WriteLine("Много");
                }
                else if (b < a)
                {
                    Console.WriteLine("Мало");
                }
                else
                {
                    Console.WriteLine("Угадал");
                    break;
                }
            }
            
        }
    }
}
