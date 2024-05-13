using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("ege aydın");
            arrayList.Add("ece aydın");
            arrayList.Add("gürdal aydın");
            arrayList.Add("güleren aydın");
            arrayList.Add("ozan aydın");

            foreach (var arrays in arrayList)
            {
                Console.WriteLine(arrays);
            }
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);
            Console.ReadLine();
        }
    }
}
