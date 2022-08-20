namespace DoubleQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new DeQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
        }
    }
}