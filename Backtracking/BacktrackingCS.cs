namespace Backtracking
{
    internal class BacktrackingCS
    {
        static void Main(string[] args)
        {
            // 예제 : 1부터 n까지 수 중 중복 없이 r개를 고른 모든 경우
            List<int> path = new List<int>();
            int n = 3; // 총 수
            int r = 2; // 고를 수
            bool[] used = new bool[n+1]; 
            BacktrackingCS backtracking = new BacktrackingCS();
            backtracking.Backtrack(path, n, r , used); // 중복 조합
            Console.WriteLine("--------------");

        }
        void Backtrack(List<int> path, int n, int r, bool[] used)
        {
            if(path.Count == r)
            {
                Console.WriteLine(string.Join(", ", path));
                return;
            }
            for(int i = 1; i <= n; i++)
            {
                if (used[i]) continue; // 중복 방지
                used[i] = true; // 현재 숫자 사용 체크
                path.Add(i); // 숫자 추가
                Backtrack(path, n, r, used); // 재귀 호출
                path.RemoveAt(path.Count - 1); // 되돌리기
                used[i] = false; // 사용 해제
            }
        }
    }
}
/*
 * 백트래킹 (Backtracking)
 * 모든 경우의 수를 탐색하는 방법
 * 가지치기를 통해 불필요한 경우를 줄이는 기법
 * 예시 : 1부터 n까지 수 중 중복 없이 r개를 고른 모든 경우
 * 시간 복잡도 : O(n^r)
 */
