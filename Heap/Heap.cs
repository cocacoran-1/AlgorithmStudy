namespace Heap
{
    internal class Heap
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1, 7 };
            HeapSort(arr);
            Console.WriteLine("정렬된 배열:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void HeapSort(int[] arr)
        {
            int len = arr.Length;
            // 배열을 힙으로 변환 (배열을 최대힙으로 만든다)
            for(int i = len / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, len, i);
            }
            // 최대값을 배열의 끝으로 보내면서 힙 성질을 유지
            for (int i = len - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // 힙 성질을 유지하기 위해 root(0)
                Heapify(arr, i, 0);
            }
        }
        static void Heapify(int[] arr, int n , int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            // 왼쪽 자식이 더 크면 largest를 왼쪽 자식으로 설정
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            // 오른쪽 자식이 더 크면 largest를 오른쪽 자식으로 설정
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }
            // largest가 i가 아니면 교환하고 재귀적으로 힙화
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }
    }
}
/* 힙 정렬
 * 이진 트리의 일종으로 완전 이진 트리
 * 트리의 모든 레벨이 채워져 있고 마지막 레벨은 왼쪽부터 채워져 있다
 * 힙은 두 가지 종류가 있다
 * 최대 힙(Max Heap) : 부모 노드의 값이 자식 노드 값보다 크거나 같은 경우
 * 최소 힙(Min Heap) : 부모 노드의 값이 자식 노드 값보다 작거나 같은 경우
 * 최대 힙을 사용하여 최대값을 배열의 끝으로 보내고, 그 후 배열의 크기를 줄이며 다시 최대 힙을 유지하는 방식
 * 배열을 힙으로 변환 : 주어진 배열을 힙 자료구조로 변환. O(n) 시간 복잡도를 가진다
 * 최대값을 힙에서 제거 : 최대 힙에서 최대값을 꺼내 배열의 마지막 원소와 교환
 * 그 후, 마지막 원소를 제외한 배열에서 힙 성질을 유지하기 위해 힙화(heapify) 작업을 수행
 * 위 과정을 배열의 크기가 1일 때까지 반복하면 정렬된 배열을 얻을 수 있다
 * 
 */
