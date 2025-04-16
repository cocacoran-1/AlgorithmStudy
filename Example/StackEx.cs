namespace Example
{
    internal class StackEx
    {
        static void Main(string[] args)
        {
            string s1 = "(()())";
            Console.WriteLine("s1 : " + IsValidParentheses(s1)); // true
            string s2 = "(()";
            Console.WriteLine("s2 : " + IsValidParentheses(s2)); // false
            string s3 = "())";
            Console.WriteLine("s3 : " + IsValidParentheses(s3)); // false
            string s4 = "(()))";
            Console.WriteLine("s4 : " + IsValidParentheses(s4)); // false
            string s5 = "({[]})";
            Console.WriteLine("s5 : " + IsValidParentheses(s5)); // true
            string s6 = "({[})]";
            Console.WriteLine("s6 : " + IsValidParentheses(s6)); // false
            string s7 = "({[()]})";
            Console.WriteLine("s7 : " + IsValidParentheses(s7)); // true
        }
        static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    // 짝이 안 맞으면 false
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
