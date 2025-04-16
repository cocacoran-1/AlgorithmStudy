namespace Data_Structures
{
    internal class Stack01
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            Console.WriteLine(stack.Pop()); // C
            Console.WriteLine(stack.Pop()); // B
            Console.WriteLine(stack.Peek()); // A (꺼내지 않고 확인)
        }
    }
}
/* 후입선출(LIFO : Last In First Out) 방식으로 데이터를 저장하는 자료구조
 * 마지막에 넣은 데이터가 가장 먼저 나오는 구조
 */