# DoubleQueue

Double Queue implementation in C#

Simple implementation of a double queue in c# using a linked list. The idea is to be able to retrieve 1st element of the queue or last with O(1) time complexity. 

![test drawio (1)](https://user-images.githubusercontent.com/7347994/185736288-c42419b8-5943-44c7-9872-784795e4a9ac.png)

## Sample

```c#
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
```

## Output at cost O(1)

```bash
Peek Left: 0
Peek Right: 10
Dequeueing
0
50
40
30
10
20
```
