using System;
using System.Collections;

namespace Task1
{
    /*
Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар 
«ключ- значение» сначала в алфавитном порядке, а затем в обратном. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList1 = new SortedList();
            sortedList1["key1"] = "A";
            sortedList1["key3"] = "B";
            sortedList1["key5"] = "C";
            sortedList1["key4"] = "D";
            sortedList1["key2"] = "E";

            foreach(DictionaryEntry entry in sortedList1)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            Console.WriteLine(new String('-',5));
            var sortedList2 = new SortedList(sortedList1, new DescComparer());

            foreach (DictionaryEntry entry in sortedList2)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

        }

        public class DescComparer : IComparer
        {
            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            public int Compare(object x, object y)
            {
                return comparer.Compare(y, x);
            }
        }
    }
}
