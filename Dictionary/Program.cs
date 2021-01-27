using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int,string>();
            kullanicilar.Add(1, "Ali Yılmaz");
            kullanicilar.Add(2, "Ayşe Yazıcı");
            kullanicilar.Add(3, "Hatice Şen");
            Console.WriteLine(kullanicilar.Count);
            
            //string kullanici = "özge";
            //bool cevap = kullanicilar.TryGetValue(3, out kullanici);
            //Console.WriteLine("key var mı "+cevap);

            MyDictionary<int, string> kullanicilar2 = new MyDictionary<int, string>();
            kullanicilar2.Add(1, "Ali Yılmaz");
            kullanicilar2.Add(2, "Hatice Şen");
            kullanicilar2.Add(3, "Ayşe Yazıcı");
            Console.WriteLine(kullanicilar2.Count);
            

        }
    }

    class MyDictionary<T, V>
    {
        T[] _keyArr;
        V[] _valueArr;
        T[] _tempKeyArr;
        V[] _tempValueArr;

        public MyDictionary()
        {
            _keyArr = new T[0];
            _valueArr = new V[0];
        }
        public void Add(T key, V value)
        {
            _tempKeyArr = _keyArr;
            _tempValueArr = _valueArr;
            _keyArr = new T[_tempKeyArr.Length + 1];
            _valueArr = new V[_tempValueArr.Length + 1];

            for (int i = 0; i < _tempKeyArr.Length; i++)
            {
                _keyArr[i] = _tempKeyArr[i];
                _valueArr[i] = _tempValueArr[i];

            }
            _keyArr[_keyArr.Length-1] = key;
            _valueArr[_valueArr.Length-1] = value;

        }
        public int Count
        {
            get { return _keyArr.Length; }
        }
        /*
        public bool TryGetValue(T key, out V value)
        {

            for (int i = 0; i < _keyArr.Length; i++)
            {
                if(_keyArr[i] == key)
                {
                    return true;
                }
            }
            return false;
        }*/


    }
}
