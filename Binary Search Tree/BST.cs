namespace Binary_Search_Tree
{
    public class TreeNode
    {
        // 하나의 노드는 값, 왼쪽 자식, 오른쪽 자식을 가진다
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    public class BinarySearchTree 
    {
        private TreeNode root; // 트리의 루트 (시작 노드)

        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if(node == null)
            {
                return new TreeNode(value); // 새로운 노드 생성
            }

            if (value < node.Value) // 삽입할 값이 현재 노드의 값보다 작으면 왼쪽 서브트리로 이동
            {
                node.Left = InsertRecursive(node.Left, value); // 왼쪽 서브트리로 이동
            }
            else if (value > node.Value) // 삽입할 값이 현재 노드의 값보다 크면 오른쪽 서브트리로 이동
            {
                node.Right = InsertRecursive(node.Right, value); // 오른쪽 서브트리로 이동
            }

            return node; // 변경된 루트 반환
        }

        // 중위 순회
        public void Inorder()
        {
            InorderRecursive(root);
            Console.WriteLine();
        }
        private void InorderRecursive(TreeNode node)
        {
            if (node != null)
            {
                InorderRecursive(node.Left); // 왼쪽 서브트리 방문
                Console.Write(node.Value + " "); // 현재 노드 방문
                InorderRecursive(node.Right); // 오른쪽 서브트리 방문
            }
        }
        
        public bool Contains(int value)
        {
            return ContainsRecursive(root, value);
        }
        
        private bool ContainsRecursive(TreeNode node, int value)
        {
            if (node == null) return false; // 노드가 null이면 값이 없음

            if (value == node.Value) return true; // 값이 현재 노드와 같으면 true 반환
            else if (value < node.Value) return ContainsRecursive(node.Left, value); // 왼쪽 서브트리 탐색
            else return ContainsRecursive(node.Right, value); // 오른쪽 서브트리 탐색
        }

        public int FindMin()
        {
            if(root == null) throw new InvalidOperationException("트리가 비어 있습니다.");

            TreeNode current = root;
            while (current.Left != null) // 왼쪽 서브트리로 계속 이동
            {
                current = current.Left;
            }
            return current.Value; // 가장 작은 값 반환
        }
        public int FindMax()
        {
            if (root == null) throw new InvalidOperationException("트리가 비어 있습니다.");

            TreeNode current = root;
            while (current.Right != null) // 오른쪽 서브트리로 계속 이동
            {
                current = current.Right;
            }
            return current.Value; // 가장 큰 값 반환
        }
        public int GetHeight()
        {
            return GetHeightRecursive(root);
        }

        private int GetHeightRecursive(TreeNode node)
        {
            if (node == null) return -1;

            int leftHeight = GetHeightRecursive(node.Left);
            int rightHeight = GetHeightRecursive(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
    internal class BST
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Insert(8);
            bst.Insert(3);
            bst.Insert(10);
            bst.Insert(1);
            bst.Insert(6);
            bst.Insert(14);

            Console.WriteLine("중위 순회 결과:");
            bst.Inorder(); // 출력: 1 3 6 8 10 14 (오름차순)
        }
    }
}
/* 이진 탐색 트리 (Binary Search Tree, BST)는 이진 트리의 일종으로, 
 * 각 노드가 최대 두 개의 자식 노드를 가지며, 
 * 왼쪽 서브트리는 해당 노드보다 작은 값들로 구성되고,
 * 오른쪽 서브트리는 해당 노드보다 큰 값들로 구성되는 자료구조. 
 * 이진 탐색 트리는 효율적인 검색, 삽입 및 삭제 연산을 지원.
 * 트리는 어디에 쓰일까?
 * 게임 개발 : 스킬 트리, 대화 분기, AI 행동 트리 등
 * 운영체제 : 파일 시스템, 프로세스 트리
 * 알고리즘 : 이진 탐색, 힙, 세그먼트 트리, 파싱
 */