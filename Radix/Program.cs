using System;
namespace Radix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            RadixSort(arr);

            Console.WriteLine("정렬된 배열:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void RadixSort(int[] arr)
        {
            // 배열에서 최댓값을 찾는다
            int max = GetMax(arr);

            // 자릿수를 기준으로 정렬
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSortByDigit(arr, exp);
            }
        }

        // 배열에서 최댓값을 찾는 함수
        static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }

        // 특정 자릿수를 기준으로 계수 정렬을 수행
        static void CountSortByDigit(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];  // 0-9 자리수에 대해 카운트

            // 각 자릿수에 대해 카운트 배열을 채운다
            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            // 카운트 배열을 누적합으로 변환한다
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // 배열을 정렬하여 output에 담는다
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            // output 배열을 원래 배열에 복사한다
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}
/*
 * 기수 정렬
 * 자릿수를 기준으로 여러 번 정렬을 반복하면서 정렬을 완성
 * 가장 낮은 자릿수부터 시작 : 1의 자리부터 시작하여, 각 자릿수를 기준으로 정렬
 * 자릿수별로 기타 정렬 알고리즘 (예: 계수 정렬)을 사용하여 정렬
 * 각 자릿수 기준으로 정렬 : 자릿수가 커질수록 자릿수에 해당하는 값을 기준으로 계속 정렬
 * 모든 자릿수를 정렬한 후 , 최종적으로 정렬된 배열을 얻음
 * 시간 복잡도는 O(N*K) , N은 배열의 크기, K는 자릿수 자릿수가 적다면 O(N)으로 볼 수 있음
 * 공간 복잡도는 O(N + K) 정렬 과정에서 임시  배열을 사용하기 때문에 추가적인 공간이 필요
 * 자릿수가 고정된 값이나 숫자 길이가 고정된 경우 유리
 * 다른 정렬 알고리즘과 결합해서 사용
 * 예를 들어 계수 정렬을 사용하여 각 자릿수를 정렬할 때 많이 사용
 * 문자열이나 숫자의 자리 수가 중요
 */