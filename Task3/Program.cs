using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Task3
{
    class Program
    {
/*
Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и 
вещественные значения, по типу «счет предприятия – доступная сумма» соответственно.  
*/
        static void Main(string[] args)
        {
            var collection1 = new Dictionary<int, decimal> { 
                { 123456, 12345.67m },
                { 123457, 123.56m },
                { 123458, 654321m }
            };


            var collection2 = new SortedList<int, decimal>();
            collection2.Add(123456, 12345.67m);
            collection2.Add(123457, 123.56m);
            collection2.Add(123458, 654321m);

            var collection3 = new SortedDictionary<int, decimal>();
            collection3[123456] = 12345.67m;
            collection3[123457] = 123.56m;
            collection3[123458] = 654321m;
        }
    }
}
