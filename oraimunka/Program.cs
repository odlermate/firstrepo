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
                Console.WriteLine("Kérlek add meg a(z) {0}. számot", i);
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }
            var max = szamok.Max();
            var min 


        }
    }
}
