using System.Collections;

namespace LinkedListImplementation
{
    public class CheckParentheses
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            var stack = new Stack();
            foreach (var t in s)
            {
                if (t == '(' || t == '{' || t == '[')
                {
                    stack.Push(t);
                    continue;
                }

                if (stack.Count != 0)
                {
                    var chars = t;
                    switch (chars)
                    {
                        case ')':
                        {
                            var top = stack.Pop().ToString();
                            if (top == "{" || top == "[")
                            {
                                return false;
                            }

                            continue;
                        }
                        case ']':
                        {
                            var top = stack.Pop().ToString();
                            if (top == "{" || top == "(")
                            {
                                return false;
                            }

                            continue;
                        }
                        case '}':
                        {
                            var top = stack.Pop().ToString();
                            if (top == "(" || top == "[")
                            {
                                return false;
                            }

                            continue;
                        }
                        default: return false;
                    }
                }

                return false;
            }

            return stack.Count == 0;
        } 
    }
}
