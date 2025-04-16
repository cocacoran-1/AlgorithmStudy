namespace LinkedList
{
    public class Node
    {
        public int Data; // 실제로 저장되는 값
        public Node Next; // 다음 노드를 가리키는 포인터

        public Node(int data)
        {
            Data = data; // 생성자에서 값 저장
            Next = null; // 처음에는 다음 노드가 없으니 null로 초기화
        }
    }
    public class MyLinkedList
    {
        Node head; // 리스트의 시작 노드를 가리키는 참조
                   // 처음엔 null로 시작 (빈 리스트)
        public void AddLast(int data)
        {
            Node newNode = new Node(data); // 새로운 노드 생성
            if (head == null) // 리스트가 비어있다면
            {
                head = newNode; // 새 노드를 head로 설정
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next; // 끝으로 이동
            }

            current.Next = newNode; // 마지막 노드의 Next를 새 노드로 설정
        }
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
        public void InsertAt(int index, int data)
        {
            Node newNode = new Node(data); // 새로운 노드 생성
            if (index == 0) // 인덱스가 0이면 head에 삽입
            {
                newNode.Next = head;
                head = newNode;
                return;
            }
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current == null) return; // 범위 초과
                current = current.Next;
            }

            newNode.Next = current.Next; // 새 노드의 Next를 현재 노드의 Next로 설정
            current.Next = newNode; // 현재 노드의 Next를 새 노드로 설정
        }

        public void Remove(int data)
        {
            if (head == null) return;
            if (head.Data == data)
            {
                head = head.Next;
                return;
            }
            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }
    }
    internal class LinkedList01
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            list.Print(); // 출력: 10 -> 20 -> 30 -> null
        }
    }
}
/*  연결 리스트 (Linked List)
 *  각각의 노드가 데이터를 저장하고, 다음 노드를 가리키는 포인터를 가지고 있는 구조
 *  왜 연결 리스트를 배워야 할까? 
 *      | 배열은 크기 고정, 중간 삽입/삭제 느림
 *      | 연결 리스트는 유동적인 크기, 중간 삽입/삭제 빠름
 *      | 나중에 트리, 그래프 같은 복잡한 자료구조의 기반이 됨
 *  
 */