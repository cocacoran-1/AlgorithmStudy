using System;

namespace Counting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
            CountingSort(arr);

            Console.WriteLine("정렬된 배열:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void CountingSort(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];

            // 최댓값과 최솟값을 찾기
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            // 빈도 배열을 생성한다
            // 빈도 배열의 길이는 최댓값과 최솟값의 차이 + 1
            int range = max - min + 1;
            int[] count = new int[range];

            // 각 숫자의 빈도를 계산한다
            // 빈도 배열의 인덱스는 각 숫자의 값에서 최솟값을 뺀 값으로 설정
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            // 누적 합 배열로 정렬된 배열을 만든다
            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (count[i] > 0)
                {
                    // 원본 배열에 정렬된 값을 넣는다
                    arr[index++] = i + min;
                    count[i]--;
                }
            }
        }
    }
}
/* 계수 정렬
 * 주어진 데이터의 범위가 한정적일 때, 각 값의 빈보를 계산하여 정렬
 * 값의 범위가 작을 때 효율적
 * 최댓값과 최솟값을 찾고 이 값들을 바탕으로 빈도 배열 생성
 * 배열 내 각 값이 몇 번 등장하는지를 기록할 빈도 배열을 생성
 * 빈도 배열 인덱스는 배열 값의 범위에 맞춰져 있다
 * 누적 합 배열 생성 :빈도 배열에 대한 누적 합을 계산하여, 각 값의 올바른 위치를 알 수 있도록 한다
 * 누적 합 배열은 배열 내 각 값들이 어디에 들어갈지를 결정
 * 최종 정렬 배열 생성 : 누적 합 배열을 바탕으로 정렬된 배열을 생성
 */
