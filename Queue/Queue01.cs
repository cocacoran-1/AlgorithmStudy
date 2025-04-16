namespace Queue
{
    internal class Queue01
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            Console.WriteLine(queue.Dequeue()); // A
            Console.WriteLine(queue.Dequeue()); // B
            Console.WriteLine(queue.Peek()); // C (꺼내지 않고 확인)
        }
    }
}
/* 선입선출 (FIFO : First In First Out) 방식으로 데이터를 저장하는 자료구조
 * 
 */