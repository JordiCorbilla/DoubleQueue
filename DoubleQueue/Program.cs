namespace DoubleQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new DeQueue<int>();
            queue.Enqueue(0);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine(queue.DequeueLeft());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.DequeueLeft());
            Console.WriteLine(queue.Dequeue());
        }
    }
}