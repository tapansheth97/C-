using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList words = new ArrayList{"Boat", "house","cat", "river", "cupboard"};

            Console.WriteLine("the plurals of all words : ");
            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i] + "s , ");
            }

            Console.WriteLine("\n\nReplacing house with castle : ");
            int HouseIndex = words.IndexOf("house");
            words.Remove("house");
            words.Insert(HouseIndex, "castle");
            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i] + " , ");
            }

            string NewWord = "friends";
            words.Add(NewWord);
            Console.WriteLine("\n\nNew Word(friends) Added new to the array list, hence updated list: {0}", NewWord);
            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i] + " , ");
            }

            Console.WriteLine("\n\nthe length of the updated list : {0}", words.Count);

            Console.WriteLine("\nthe list of words which contains the length of characters as 7: ");
            foreach (string word in words)
            {
                if (word.ToCharArray().Length == 7)
                {
                    Console.Write(word);
                }
            }

            Console.WriteLine("\n\nthe Word on 3rd position : {0}", words[2]);

            Console.WriteLine("\nall the words in ascending order : ");
            var temp = words;
            temp.Sort();
            for (int i = 0; i < temp.Count; i++)
            {
                Console.Write(temp[i] + " , ");
            }
            
            Console.WriteLine("\n\nthe reverse of an array : ");
            temp.Reverse();
            for (int i = 0; i < temp.Count; i++)
            {
                Console.Write(temp[i] +" , ");
            }

            Console.ReadKey();
        }
    }
}
