using System;

namespace DictionaryGirisOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> müsteriler = new MyDictionary<string, int>();
            müsteriler.Add(6,"Yunus Emre");
            Console.WriteLine(müsteriler.Count);
            
            //1

            müsteriler.Add(7, "Halil İbrahim");
            Console.WriteLine(müsteriler.Count);

            müsteriler.Add(8, "Habibe Nur");
            Console.WriteLine(müsteriler.Count);



        }
    }
}
