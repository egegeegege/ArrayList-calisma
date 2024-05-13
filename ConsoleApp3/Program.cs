using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste1 = new ArrayList() { 10, 20, 30, 40, 50 };
            ArrayList liste2 = new ArrayList() { "A", "B", "C", "D", "E" };

            Console.WriteLine(liste1.Contains(10));
            Console.WriteLine(liste2.Contains("A"));

            Console.WriteLine("**********************************");

            Console.WriteLine(liste1.Contains(12));
            Console.WriteLine(liste2.Contains("V"));

            Console.WriteLine("**********************************");


            ArrayList liste3 = new ArrayList() { 23, 45, 12, 9, 142, 93, 18 };

            Console.WriteLine("bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            bool bul = liste3.Contains(sayi);

            if (bul)
            {
                Console.WriteLine("sayı listedde mevcut");
            }
            else
            {
                Console.WriteLine("sayuı listede mevcut değil");
            }

            Console.ReadLine();
        }
    }
}
