namespace Binary_Search
{
    internal class BinarySearchCS
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11 };
            int target = 5;
            BinarySearchCS binarySearch = new BinarySearchCS();
            int result = binarySearch.BinarySearch(arr, target);
            Console.WriteLine(result != -1 ? $"찾은 인덱스: {result}" : "찾지 못했습니다.");
        }
        int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return mid; // 찾은 경우
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // 오른쪽 절반 탐색
                }
                else
                {
                    right = mid - 1; // 왼쪽 절반 탐색
                }
            }
            return -1; // 찾지 못한 경우
        }
    }
}
/* 이진 탐색 (Binary Search)
 * 정렬된 배열에서 중간값과 비교하여 탐색 범위를 반으로 줄여나가는 방법
 * 시간 복잡도 : O(log n)
 */
