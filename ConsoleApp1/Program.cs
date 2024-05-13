using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList liste = new ArrayList() { 1, 23, 4, 5, 6, 7, 8, "ege" };
                Console.WriteLine(liste.Count);

                foreach (var i in liste)
                {
                    Console.WriteLine((int)i + 10);
                }

                liste.Add(DateTime.Now);
            }
            catch (Exception)
            {
                Console.WriteLine("yapılamadı");
            }

            Console.ReadLine();
        }
    }
}
