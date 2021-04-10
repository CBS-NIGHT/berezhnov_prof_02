using System;
using System.Collections.Specialized;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCollection = new MyOrderedDictionary();
         
            myCollection.Add("testKey1", "testValue1");
            myCollection.Add("testKey2", "testValue2");
            myCollection.Add("keyToDelete", "valueToDelete");
            myCollection.Add("testKey3", "testValue3");

            myCollection.DisplayCompareKeys(0, 1);
            myCollection.DisplayCompareKeys(0, 2);
            myCollection.DisplayCompareKeys(1, 0);
            myCollection.DisplayCompareKeys(3, 2);
            myCollection.DisplayCompareKeys(0, 5);

        }
    }
}
