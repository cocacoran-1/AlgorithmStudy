namespace ExampleQueue
{
    internal class QueueEx
    {
        static void Main(string[] args)
        {
            int[] priorities = { 2, 1, 3, 2 };
            int location = 2;
            int result = GetPrintOrder(priorities, location);
            Console.WriteLine($"Print order for location {location} : {result}");

            int[] priorities2 = { 1, 1, 9, 1, 1, 1 };
            int location2 = 0;
            int result2 = GetPrintOrder(priorities2, location2);
            Console.WriteLine($"Print order for location {location2} : {result2}");

            int[] priorities3 = { 1, 2, 3, 4, 5 };
            int location3 = 4;
            int result3 = GetPrintOrder(priorities3, location3);
            Console.WriteLine($"Print order for location {location3} : {result3}");
        }
        static int GetPrintOrder(int[] priorities, int location)
        {
            Queue<(int priority, int index)> queue = new Queue<(int priority, int index)>();
            for (int i = 0; i < priorities.Length; i++)
            {
                queue.Enqueue((priorities[i], i));
            }
            int printOrder = 0;
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (queue.Any(item => item.priority > current.priority))
                {
                    queue.Enqueue(current);
                }
                else
                {
                    printOrder++;
                    if (current.index == location)
                    {
                        return printOrder;
                    }
                }
            }

            return -1; // 도달할 수 없는 경우
        }
    }
}
