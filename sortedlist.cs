using System;
using System.Collections.Generic;


namespace ClassObjectsDemo
{
    class Sortedlist
    {
        public void Register()
        {
            SortedList<int, string> slist = new SortedList<int, string>();

            slist.Add(4, "Mohan");
            slist.Add(3, "Eligious");
            slist.Add(5, "Trisha");
            slist.Add(1, "Sree");

            slist[2] = "Gaurav";

            foreach (KeyValuePair<int, string> item in slist)
            {
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
            }
        }
    }
}
