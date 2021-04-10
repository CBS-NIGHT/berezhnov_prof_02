using System;
using System.Collections;
using System.Collections.Specialized;

namespace Task4
{
    public class MyOrderedDictionary : OrderedDictionary
    {
        public void DisplayCompareKeys(int index1, int index2)
        {
            if (index1 >= 0 && index1 < Count && index2 >= 0 && index2 < Count)
            {
                ICollection keyCollection = Keys;

                String[] keys = new String[Keys.Count];
                keyCollection.CopyTo(keys, 0);

                char compare = String.Compare(keys[index1], keys[index2]) > 0 ?
                    '>' : '<';
                
                Console.WriteLine($"key{index1}:'{keys[index1]}' {compare} key{index2}:'{keys[index2]}'");
            }
            else Console.WriteLine("none");
        }
    }
}