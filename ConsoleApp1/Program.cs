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

 		Random rnd = new Random();
            for (int i = 0; i < 20; i++)
			{
                int num = rnd.Next(101);
                szamok.Add(num);
			}
            
            foreach (var item in szamok)
	{
                Console.WriteLine(item);
	}



            // 2. T. Marci: Kiírsa a legnagyobb számot




            // 3. Sz. M. Kiírja a legkisebb számot

            int min = 0;

            for (int i = 0; i < szamok.Count; i++)
			{
                if (szamok[i] < szamok[min])
                {
                    min = i;
	            }
			}

            Console.WriteLine(Lista[min]);


            //4. Ádámka: A számok átlaga

		double Atlag =0;
		
		for (int i =0; i < szamok.Count; i++)
		{
			Atlag += szamok[i]
		}	
		double atlag = Atlag / (double)szamok.Count;
		Console.WriteLine("Átlag: {0}", Atlag);

            //5. E. M. : Számok darabszáma

            int mennyi = 0;

            for (int i = 0; i < szamok.Count(); i++)
            {
                mennyi = mennyi + szamok[i];
            }
            Console.WriteLine("A számok mennyisége: {0}",mennyi);

            //6. páros v páratlan számból van több?


            if(szamok.Where(x => x%2 == 0 ).Count() > szamok.Where(x => x%2 != 0 ).Count())
                Console.WriteLine("Páros számból van több");
            else Console.WriteLine("Páratlan számból van több");




            



            Console.ReadKey();

        }
    }
}
