using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Random random = new Random();
            int random2 = random.Next(0, 50);
            int hak = 0;


            foreach (var sayi in sayilar)
            {
                while (hak < 10)
                {
                    if ((int)sayi == random2)
                    {
                        Console.WriteLine("aranan sayı mevcut ütryilrtn sayı {0}", random2);
                    }
                    else
                    {
                        Console.WriteLine("aradığınız sayı bulunamadı");
                    }
                    hak++;

                }

            }
            Console.ReadLine();
        }
    }
}
