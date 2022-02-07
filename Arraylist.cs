using System;
using System.Collections;

namespace ClassObjectsDemo
{
    class StudentDetail
    {
        public void SDetail()
        {
            ArrayList fullDetails = new ArrayList();
           
           
            fullDetails.Add("Praveen");
            Console.WriteLine("ArrayList Count: " + fullDetails.Count);
            Console.WriteLine("ArrayList Capacity: " + fullDetails.Capacity);

            fullDetails.Add(24);
            Console.WriteLine("ArrayList Count: " + fullDetails.Count);
            Console.WriteLine("ArrayList Capacity: " + fullDetails.Capacity);

            fullDetails.Add("TamilNadu");
            Console.WriteLine("ArrayList Count: " + fullDetails.Count);
            Console.WriteLine("ArrayList Capacity: " + fullDetails.Capacity);

            fullDetails.Add(96.5);
            Console.WriteLine("ArrayList Count: " + fullDetails.Count);
            Console.WriteLine("ArrayList Capacity: " + fullDetails.Capacity);

            fullDetails.Add("CBSE");
            Console.WriteLine("ArrayList Count: " + fullDetails.Count);
            Console.WriteLine("ArrayList Capacity: " + fullDetails.Capacity);

            fullDetails.Insert(1, 50);
            fullDetails.Remove("CBSE");
            fullDetails.RemoveAt(4);

            ArrayList extradetail = new ArrayList() { 10, "Hi" };
            fullDetails.AddRange(extradetail);

            foreach (var item in fullDetails)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("TamilNadu exist? "+ fullDetails.Contains("TamilNadu"));

        }
    }
}
