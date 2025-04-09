using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm01
{
    internal class Selection
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1 };
            SelectionSort(arr);

            Console.WriteLine("정렬된 배열:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void SelectionSort(int[] arr)
        {
            int len = arr.Length;
            /* i는 이미 정렬된 부분을 제외한 나머지 부분을 처리하려고 하는 현재 위치
             * i = 0 이면 첫 번째 자리, i =1 이면 두 번째 자리 처리
             * 따라서 i는 0 부터 len - 1 까지 반복
             */
            for (int i = 0; i < len -1; i++)
            {
                int minIndex = i;
                /* j는 i 이후의 원소를 비교하면서 가장 작은 값을 찾는다
                 * i = 0 이면 j는 1 부터 시작해서 배열의 끝까지 반복
                 * 정렬된 위치를 제외한 나머지 부분 모두와 비교 
                 */
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
}
/*
 * 선택 정렬의 시간 복잡도는 최악, 평균, 최손 모두 O(n^2)이다
 * 공간 복잡도는 O(1), 추가적인 메모리를 사용하지 않는다
 * 교환 횟수는 선택 정렬이 버블 정렬보다 적다 대신 비교 횟수는 많다
 * 그래서 선택 정렬은 교환 비용이 중요한 경우 (예를 들어 배열의 크기가 클 때) 유리하다
 * 선택 정렬 , 버블 정렬 모두  큰 데이터를 정렬할 때는 비효율적
 */