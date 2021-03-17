using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryGirisOrnek
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] arrayKey;
        Tvalue[] arrayValue;

        public MyDictionary()
        {
            arrayKey = new Tkey[0];
            arrayValue = new Tvalue[0];
        }

        public void Add(Tvalue müsteri, Tkey numara)
        {
            Tkey[] tempKey = arrayKey;
            arrayKey = new Tkey[tempKey.Length + 1];

            Tvalue[] tempValue = arrayValue;
            arrayValue = new Tvalue[tempValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                arrayKey[i] = tempKey[i];
                arrayValue[i] = tempValue[i];
            }
            arrayKey[arrayKey.Length - 1] = numara;
            arrayValue[arrayValue.Length - 1] = müsteri;
        }

        public int Count
        {
            get { return arrayKey.Length; }
        }

    }
}
