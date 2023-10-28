using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            //KEY-VALUE EKLEME
            myDictionary.Add(1, "Bir");
            myDictionary.Add(2, "İki");
            myDictionary.Add(3, "Üç");

            //Listeleme
            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine("Anahtar: " + myDictionary.Keys[i] + ", Değer: " + myDictionary.Values[i]);
            }
        }
    }
}
