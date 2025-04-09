using System;

namespace Algorithm01
{
    internal class Bubble
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 1 };
            BubbleSort(arr);
            Console.WriteLine("정렬된 배열:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static void BubbleSort(int[] arr)
        {
            int len = arr.Length;

            /* 배열의 끝까지 반복
               첫 번째 반복에서 가장 큰 수가 마지막으로 이동
               두 번째 반복에서 두 번째로 큰 수가 그 다음으로 이동
               가장 큰 값을 배열의 끝으로 밀어 넣는 방식
               매 반복마다 정렬되지 않은 부분의 크기가 하나씩 줄어듦
               배열의 크기 만큼 모두 반복할 필요는 없음
               배열의 크기 - 1 만큼 반복하면 됨
            */
            for (int i = 0; i < len - 1; i++)
            {
                /* 정렬되지 않은 부분을 반복
                   정렬 할때 마다 반복할 부분이 1씩 줄어듦
                   i 번 반복 할 때마다 마지막 i 개의 수는 정렬
                   마지막 i 개의 수는 정렬이 되어 있으므로 반복할 필요 없음
                   j에 마지막 원소를 넣으면 배열초과 오류 발생
                   따라서 j는 마지막 원소 이전까지 반복 len - 1 까지
                   len - 1 - i 만큼 반복
                */
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        // 교환 과정
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
/*
 * 버블 정렬의 시간 복잡도는 최악의 경우 O(n^2), 평균 O(n^2), 최선 O(n)이다
 * 공간 복잡도는 O(1), 추가적인 메모리를 사용하지 않는다
 * 비교 횟수는 적다 하지만 교환 횟수는 많다
 */
