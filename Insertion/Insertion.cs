namespace Alogorithm02
{
    internal class Insertion
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1 };
            InsertionSort(arr);
            Console.WriteLine("정렬된 배열:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void InsertionSort(int[] arr)
        {
            int len = arr.Length;
            /* 첫 번째 원소는 정렬된 상태로 가정
             * 두 번째 원소부터 시작
             */
            for (int i = 1; i< len; i++)
            {
                int key = arr[i];
                int j = i - 1;
                
                // 현재 원소를 이전 원소들과 비교
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
    /*
     * 가장 직관적인 정렬 알고리즘
     * 배열을 부분적으로 정렬된 상태로 유지하면서 정렬
     * 삽입 정렬의 시간 복잡도는 최악, 평균 O(n^2), 최선 O(n)이다
     * 삽입 정렬은 정렬된 부분과 정렬되지 않은 부분을 나누고
     * 정렬된 부분에 정렬되지 않은 원소를 삽입하는 방식으로 동작한다
     * 삽입 정렬은 작은 데이터에 대해서는 빠르지만 큰 데이터에 대해서는 느리다
     */
}
