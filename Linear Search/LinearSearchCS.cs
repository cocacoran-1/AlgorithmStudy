namespace Linear_Search
{
    internal class LinearSearchCS
    {
        static void Main(string[] args)
        {
        }
        int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1; 
        }
    }
}
/* 선형 탐색 (Linear Search)
 * 앞에서부터 하나씩 비교하면서 원하는 값을 찾는 방법
 * 시간 복잡도 : O(n)
 */
