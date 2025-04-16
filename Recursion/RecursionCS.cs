namespace Recursion
{
    internal class RecursionCS
    {
        static void Main(string[] args)
        {
        }
        int Factorial(int n)
        {
            if(n == 1) return 1;
            return n * Factorial(n - 1);

        }
        int Fibonacci(int n)
        {
            if(n == 0) return 0;
            if(n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
/* 재귀 함수 (Recursion)
 * 함수가 자기 자신을 다시 호출하는 방식
 */
