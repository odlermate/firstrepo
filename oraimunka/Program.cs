using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraimunka
{
    class Program
    {
        static void Main(string[] args)
        {
            var szamok = new List<int>();
            Console.WriteLine("Kérlek add meg hány számot szeretnél megadni");
            int e = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < e; i++)
            {
                try
                {
                    Console.WriteLine("Kérlek add meg a(z) {0}. számot", i + 1);
                    szamok.Add(Convert.ToInt32(Console.ReadLine()));
                }catch
                {
                    Console.WriteLine("nem megfelelő számot adtál meg!");
                    i--;
                }
                
            }
            var max = szamok.Max();
            var min = szamok.Min();
            Console.WriteLine("A legnagyobb szám: {0}, a legkissebb pedig: {1}", max, min);




            Console.ReadKey();
        }
    }
}
