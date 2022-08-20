//  Copyright (c) 2022, Jordi Corbilla
//  All rights reserved.
//
//  Redistribution and use in source and binary forms, with or without
//  modification, are permitted provided that the following conditions are met:
//
//  - Redistributions of source code must retain the above copyright notice,
//    this list of conditions and the following disclaimer.
//  - Redistributions in binary form must reproduce the above copyright notice,
//    this list of conditions and the following disclaimer in the documentation
//    and/or other materials provided with the distribution.
//  - Neither the name of this library nor the names of its contributors may be
//    used to endorse or promote products derived from this software without
//    specific prior written permission.
//
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
//  AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
//  ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
//  LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
//  CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
//  SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
//  INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
//  CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
//  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
//  POSSIBILITY OF SUCH DAMAGE.

namespace DoubleQueue
{
    public class DeQueue<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Size { get; internal set; }

        public DeQueue()
        {
            Size = 0;
        }

        public void Enqueue(T item)
        {
            var node = new Node<T>(item);

            //Add the first node to the Head object
            if (Head is null)
            {
                Head = node;
            }

            //Add the first or any other object to the tail object
            if (Tail is null)
            {
                Tail = node;
            }
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
                Tail = node;
            }
            Size++;
        }

        public T Dequeue()
        {
            if (Tail == null)
                throw new InvalidOperationException("Queue is empty");

            T item = Tail.Value;
            Tail = Tail.Previous;
            if (Tail is not null)
                Tail.Next = null;
            Size--;
            return item;
        }

        public T DequeueRight()
        {
            return Dequeue();
        }

        public T DequeueLeft()
        {
            if (Head == null)
                throw new InvalidOperationException("Queue is empty");

            T item = Head.Value;
            Head = Head.Next;
            if (Head is not null)
                Head.Previous = null;
            Size--;
            return item;
        }
    }
}
