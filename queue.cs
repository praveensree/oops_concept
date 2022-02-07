using System;
using System.Collections;


namespace ClassObjectsDemo
{
    class Animals
    {
        public void AnimalNames()
        {
            Queue que = new Queue();
            que.Enqueue("Lion");
            que.Enqueue("Tiger");
            que.Enqueue("Cheetah");
            que.Enqueue("Leopard");
            que.Enqueue("Jaguar"); 

            Console.WriteLine($"Number of Elements in Queue: {que.Count}" );

            Console.WriteLine(que.Peek());

            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }

            Console.WriteLine($"Number of Elements in Queue: {que.Count}");


           
        }
    }
}
