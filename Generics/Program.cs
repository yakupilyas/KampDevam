using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
           

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            Console.WriteLine(sehirler2.Count);
            
        }
    }

    class MyList<T>  //generic class
    {
        T[] _array;
        T[] _tempArray;   //temparray Arrayımizin önceki değerlerini tutuyor.
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;     // _tempArray dizisi _array dizisi elemanlarının elemanlarını tutuyor.
            _array = new T[_array.Length + 1];  //diziye ekleme yapıldıgında dizi elemanalrı sayısını arttırıyor.
           
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];  //for döngüsü ile tempArray  dizisi elemanlarını tek tek array dizisine aktardık.
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }       
        }

    }
}
