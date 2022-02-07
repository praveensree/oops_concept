using System;
using System.Collections.Generic;


namespace ClassObjectsDemo
{
    class Dict
    {
        public void Register()
        {
            Dictionary<int, string> dcnr = new Dictionary<int, string>();

            dcnr.Add(4, "Praveen");
            dcnr.Add(3, "Raghav");
            dcnr.Add(5, "prince");
            dcnr.Add(1, "Sajith");

            dcnr[2] = "Reegan";

            foreach (KeyValuePair<int, string> item in dcnr)
            {
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
            }
        }
    }
}