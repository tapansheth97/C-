using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> PDictionary = new Dictionary<string, int>();
            PDictionary.Add("Atal Bihari Vajpayee", 1998);
            PDictionary.Add("Narendra Modi", 2014);
            PDictionary.Add("Manmohan Singh", 2004);

            Console.WriteLine("details of prime ministers: ");
            foreach (KeyValuePair<string, int> p in PDictionary)
            {
                Console.WriteLine("Name : " + p.Key + "\tYear :" + p.Value);
            }

            Console.Write("\nPrime Minister of 2004 : ");
            foreach (KeyValuePair<string, int> p in PDictionary)
            {
                if (p.Value.Equals(2004))
                {
                    Console.WriteLine(p.Key);
                }
            }

            PDictionary.Add("you are the new Prime Minister",2019);

            Console.Write("\nPrime minister of 2019 added : \n");
            foreach (KeyValuePair<string, int> p in PDictionary)
            {
                Console.WriteLine("Name : " + p.Key + "\tYear :" + p.Value);
            }
            
            var SortedPDictionary = new SortedDictionary<string, int>(PDictionary);
            Console.WriteLine("\nSorted Dictionary by year : ");
            foreach (KeyValuePair<string, int> p in SortedPDictionary)
            {
                Console.WriteLine("Name : " + p.Key + "\tYear :" + p.Value);
            }

            Console.ReadKey();

        }
    }
}
