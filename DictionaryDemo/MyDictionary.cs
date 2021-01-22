using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    public class MyDictionary<TK, TV>
    {
        TK[] TKey; TV[] TValue;

        public MyDictionary()
        {
            TKey = new TK[0];
            TValue = new TV[0];
        }

        public void Add(TK key, TV value)
        {
            TK[] tempKey = TKey;
            TV[] tempValue = TValue;

            TKey = new TK[TKey.Length + 1];
            TValue = new TV[TValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                TKey[i] = tempKey[i];
                TValue[i] = tempValue[i];
            }

            TKey[TKey.Length - 1] = key;
            TValue[TValue.Length - 1] = value;
        }

        public int Lenght {
            get { return TKey.Length; }
        }

        public TK[] GetKeys {
            get { return TKey; }
        }

        public TV[] GetValues
        {
            get { return TValue; }
        }


    }
}
