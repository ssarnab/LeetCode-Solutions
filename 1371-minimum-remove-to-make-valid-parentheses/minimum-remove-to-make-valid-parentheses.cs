public class Solution {
     public string MinRemoveToMakeValid(string s)
 {
     var stack = new Stack<int>(); // To keep track of '(' indices
     var removeSet = new HashSet<int>(); // To mark indices for removal

     // Identify invalid parentheses
     for (int i = 0; i < s.Length; i++)
     {
         if (s[i] == '(')
         {
             stack.Push(i);
         }
         else if (s[i] == ')')
         {
             if (stack.Count > 0) stack.Pop(); // Found a matching pair
             else removeSet.Add(i); // Unmatched ')' found, mark for removal
         }
     }

     // Any remaining '(' in the stack are unmatched, mark them for removal
     while (stack.Count > 0)
     {
         removeSet.Add(stack.Pop());
     }

     // Construct the valid string
     var sb = new StringBuilder();

     for (int i = 0; i < s.Length; i++)
     {
         if (!removeSet.Contains(i)) sb.Append(s[i]);
     }

     return sb.ToString();
 }
}