namespace DoubleQueue.Tests
{
    public class DeQueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var q = new DeQueue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();
            q.Dequeue();
            q.Enqueue(4);
            Assert.That(q.Dequeue(), Is.EqualTo(4));
            Assert.That(q.Dequeue(), Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            var q = new DeQueue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.DequeueLeft();
            q.DequeueLeft();
            q.Enqueue(4);
            Assert.That(q.Dequeue(), Is.EqualTo(4));
            Assert.That(q.Dequeue(), Is.EqualTo(3));
        }
    }
}