using System;
using System.Collections;


namespace ClassObjectsDemo
{
    class Countries
    {
        public void CountryNames()
        {
            Hashtable htbl = new Hashtable();
            htbl.Add("UK", "United Kingdom");
            htbl.Add("USA", "United States of America");
            htbl["IN"] = "India";
          


            foreach (DictionaryEntry item in htbl)
            {
                Console.WriteLine($"Key = {item.Key}, Value = { item.Value}");
            }
            htbl.Remove("USA");
            Console.WriteLine("Contains Key INDIA: {0}", htbl.ContainsKey("IN"));
        }
    }
}
