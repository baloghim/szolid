using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> szamok = new List<int>;

            // 1. Isti: 20 véletlenszám 1 és 100 között





            // 2. T. Marci: Kiírsa a legnagyobb számot




            // 3. Sz. M. Kiírja a legkisebb számot



            //4. Ádámka: A számok átlaga


            //5. E. M. : Számok darabszáma



            //6. páros v páratlan számból van több?


            if(szamok.Where(x => x%2 == 0 ).Count() > szamok.Where(x => x%2 != 0 ).Count())
                Console.WriteLine("Páros számból van több");
            else Console.WriteLine("Páratlan számból van több");




            



            Console.ReadKey();

        }
    }
}
