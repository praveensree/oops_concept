using System;
using System.Collections;


namespace ClassObjectsDemo
{
    class Birds
    {
        public void BirdNames()
        {
            Stack stk = new Stack();
            stk.Push("Lion");
            stk.Push("Tiger");
            stk.Push("Cheetah");
            stk.Push("Leopard");
            stk.Push("Jaguar");

            Console.WriteLine($"Number of Elements in Queue: {stk.Count}");

            Console.WriteLine(stk.Peek());

            while (stk.Count > 0)
            {
                Console.WriteLine(stk.Pop());
            }

            Console.WriteLine($"Number of Elements in Queue: {stk.Count}");



        }
    }
}
