
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string recenica = "Danas radimo sa klasom String! ";

            Console.WriteLine("Broj znakova u recenici je: " + recenica.Length);

            Console.WriteLine("\n ------ ToLower is ToUpper");
            Console.WriteLine(recenica.ToLower());
            Console.WriteLine(recenica.ToUpper());

            Console.WriteLine("\n -------- SubString");
            Console.WriteLine(recenica.Substring(6));
            Console.WriteLine(recenica.Substring(0,5));

            Console.WriteLine(" \n ------ Replace");
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));

            Console.WriteLine("\n ------- Split");
            string[] rijeci = recenica.Split(' ');
            for(int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);   
            }

            Console.WriteLine("\n --- indexOf i Insert");
            int pozicija = recenica.IndexOf("radimo");
            if (pozicija >= 0)
            {
                Console.WriteLine(recenica.Insert(pozicija, "intenzivno "));
            }


            Console.ReadKey();
        }
    }
}
