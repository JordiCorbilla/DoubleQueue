namespace DoubleQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new DeQueue<int>();
            queue.Enqueue(0);
            queue.Enqueue(10);
            Console.WriteLine($"Peek Left: {queue.PeekLeft()}");
            Console.WriteLine($"Peek Right: {queue.PeekRight()}");
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine("Dequeueing");
            Console.WriteLine(queue.DequeueLeft());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.DequeueLeft());
            Console.WriteLine(queue.Dequeue());
        }
    }
}