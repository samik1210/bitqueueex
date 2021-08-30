using System;
using System.Collections;

namespace bitqueueex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Queue my_queue = new Queue();
            my_queue.Enqueue("samu");
            my_queue.Enqueue(2);
            my_queue.Enqueue(200);
            my_queue.Enqueue(null);
            my_queue.Enqueue(4.4);
            my_queue.Enqueue("SAMIKSHA");
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
