
using System;

namespace ClassObjectsDemo
{
    public class TypedNumber
    {
        public void Data<T>(T a, T b)
        {
            Console.WriteLine("Param1: {0}", a);
            Console.WriteLine("Param2: {0}", b);
        }
    }
    
}