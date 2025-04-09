using System;

namespace Algorithm04
{
    internal class MergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1, 7 };
            MergeSortA(arr, 0, arr.Length - 1);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void MergeSortA(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // 중간 인덱스 계산
                int mid = (left + right) / 2;
                // 왼쪽 부분 배열 정렬
                MergeSortA(arr, left, mid);
                // 오른쪽 부분 배열 정렬
                MergeSortA(arr, mid + 1, right);
                // 두 부분 배열을 병합
                Merge(arr, left, mid, right);
            }
        }
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1; // 왼쪽 부분 배열의 크기
            int n2 = right - mid; // 오른쪽 부분 배열의 크기

            int[] L = new int[n1]; // 왼쪽 부분 배열
            int[] R = new int[n2]; // 오른쪽 부분 배열

            Array.Copy(arr, left, L, 0, n1); // 왼쪽 부분 배열 복사
            Array.Copy(arr, mid + 1, R, 0, n2); // 오른쪽 부분 배열 복사

            int i = 0, j = 0, k = left; // i: 왼쪽 배열 인덱스, j: 오른쪽 배열 인덱스, k: 원본 배열 인덱스

            // 두 배열을 서로 비교하며 작은 값부터 원본 배열에 넣는다
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // 만약 왼쪽 배열에 남은 원소가 있다면 그 값들을 원본 배열에 넣는다
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            // 만약 오른쪽 배열에 남은 원소가 있다면 그 값들을 원본 배열에 넣는다
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}

/* 병합 정렬 
 * 분할 정복 방식으로 동작
 * 배열을 반씩 나누고, 각 부분을 정렬 한 후 다시 합치는 방식
 * 퀵 정렬보다 최악의 경우에도 O(n log n)의 성능을 보장하는 안정적인 알고리즘
 * 두 배열을 비교하면서 하나씩 처리하므로 병합 과정은 선형 시간(O(n))이다
 * 배열을 반으로 나누는 작업은 로그 시간(O(log n))이 걸린다
 * 이 두가지 작업을 합치면 O(n log n) 이 된다
 */
