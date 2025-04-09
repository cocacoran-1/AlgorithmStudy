using System;

namespace Alogorithm03
{
    internal class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1, 7};
            QSort(arr, 0, arr.Length - 1);
            Console.WriteLine("정렬된 배열:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void QSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                // 기준값을 찾고 분할된 배열을 반환
                int pivotindex = Partition(arr, low, high);
                // 기준값을 기준으로 왼쪽 오른쪽 부분 배열을 재귀적으로 정렬
                QSort(arr, low, pivotindex - 1);  // 왼쪽
                QSort(arr, pivotindex + 1, high); // 오른쪽
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // 기준값 선택 (여기서는 마지막 원소를 기준값으로 선택)
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            // 기준값을 올바른 위치에 배치
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            // 기준값의 인덱스를 반환
            return i + 1;
        }
    }
}
/*
 * 분할 정복 방식을 사용 
 * 기준값(pivot)을 설정하고, 배열을 두 개의 부분 배열로 분할
 * 나눠진 각 부분 배열을 다시 재귀적으로 퀵 정렬을 이용해 정렬
 * 위 과정을 반복하여 최종적으로 배열이 정렬
 * 빠르고 효율적인 정렬 알고리즘
 * 최악의 경우는 O(n^2)지만 이는 주로 배열이 이미 정렬되어 있을 때 발생
 * 이를 방지하기 위해 랜던 피벗을 선택하거나, 중앙값을 피벗으로 선택하는 방법 사용 가능
 * 배열을 직접 변경하면서 정렬 하기 때문에 추가적인 메모리를 사용하지 않는다
 * 분할 정복 방식으로 동작하여 배열의 크기가 커질수록 성능이 향상
 */